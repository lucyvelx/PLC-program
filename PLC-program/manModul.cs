using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PLC_program
{
    public partial class manModul : Form
    {
        //private System.Windows.Forms.Timer evaluationTimer;


        //int click = 0;
        //private Timer refreshTimer;
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; Convert Zero Datetime = true ; database = bakalarska_praca; password=");


        public manModul()
        {

            
            InitializeComponent();

            //refreshTimer = new Timer();
            //refreshTimer.Interval = 5000; // Set the interval to 5 seconds (5000 milliseconds)
            //refreshTimer.Tick += RefreshTimer_Tick;


            try

            {
                connection.Open();
                // prikaz na vyber hodnot zo vstupu I136.5 z manipulatora - rameno zobralo vyrobok a spustil sa pohyb nad triedicku
                MySqlCommand command1 = new MySqlCommand("SELECT hodnota,cas as cas1 FROM man_vstupy WHERE absolutna_adresa='I136.5' ORDER BY id DESC limit 1", connection);
                // prikaz na vyber hodnot zo vstupu I136.0 na triedicke - vyrobok sa neobjavil na páse
                MySqlCommand command2 = new MySqlCommand("SELECT hodnota,cas as cas2 FROM tr_vstupy WHERE absolutna_adresa='I136.0' ORDER BY id DESC limit 1", connection);

                DateTime timestamp1 = new DateTime();
                DateTime timestamp2 = new DateTime();

                using (var reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp1 = reader.GetDateTime(1);


                    }
                }
                using (var reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp2 = reader.GetDateTime(1);

                    }
                }
                TimeSpan difference = timestamp1 - timestamp2;
                double seconds = difference.TotalSeconds;



                if (seconds > 5)
                {
                    MessageBox.Show("Manipulátor nepreniesol výrobok na pás!");
                    //vlozenie udajov do tabulky
                    MySqlCommand command = new MySqlCommand("insert into chyby (snimac1,snimac2) values ('I136.5','I136.0')", connection);
                    command.ExecuteNonQuery();
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            try

            {
                connection.Open();
                // prikaz na vyber hodnot zo vstupu I136.5 z manipulatora - rameno zobralo vyrobok a spustil sa pohyb nad triedicku
                MySqlCommand command1 = new MySqlCommand("SELECT hodnota,cas as cas1 FROM man_vstupy WHERE absolutna_adresa='I136.2' ORDER BY id DESC limit 1", connection);
                // prikaz na vyber hodnot zo vstupu I136.0 na triedicke - vyrobok sa neobjavil na páse
                MySqlCommand command2 = new MySqlCommand("SELECT hodnota,cas as cas2 FROM tr_vstupy WHERE absolutna_adresa='I136.0' ORDER BY id DESC limit 1", connection);

                DateTime timestamp1 = new DateTime();
                DateTime timestamp2 = new DateTime();

                using (var reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp1 = reader.GetDateTime(1);


                    }
                }
                using (var reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp2 = reader.GetDateTime(1);

                    }
                }
                TimeSpan difference = timestamp1 - timestamp2;
                double seconds = difference.TotalSeconds;



                if (seconds > 5)
                {
                    MessageBox.Show("Manipulátor nepreniesol výrobok na pás!");
                    //vlozenie udajov do tabulky
                    MySqlCommand command = new MySqlCommand("insert into chyby (snimac1,snimac2) values ('I136.2','I136.0')", connection);
                    command.ExecuteNonQuery();
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            try

            {
                connection.Open();
                // prikaz na vyber hodnot zo vstupu I136.5 z manipulatora - rameno zobralo vyrobok a spustil sa pohyb nad triedicku
                MySqlCommand command1 = new MySqlCommand("SELECT hodnota,cas as cas1 FROM tr_vstupy WHERE absolutna_adresa='I136.0' ORDER BY id DESC limit 1", connection);
                // prikaz na vyber hodnot zo vstupu I136.0 na triedicke - vyrobok sa neobjavil na páse
                MySqlCommand command2 = new MySqlCommand("SELECT hodnota,cas as cas2 FROM tr_vstupy WHERE absolutna_adresa='I136.3' ORDER BY id DESC limit 1", connection);

                DateTime timestamp1 = new DateTime();
                DateTime timestamp2 = new DateTime();

                using (var reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp1 = reader.GetDateTime(1);


                    }
                }
                using (var reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        timestamp2 = reader.GetDateTime(1);

                    }
                }
                TimeSpan difference = timestamp1 - timestamp2;
                double seconds = difference.TotalSeconds;



                if (seconds > 5)
                {
                    MessageBox.Show("Výrobok nebol zatriedený!");
                    //vlozenie udajov do tabulky
                    MySqlCommand command = new MySqlCommand("insert into chyby (snimac1,snimac2) values ('I136.0','I136.3')", connection);
                    command.ExecuteNonQuery();
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            try
            {

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlCommand command = new MySqlCommand("SELECT * FROM chyby ", connection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                //DataGridView2 = da.Fill(dataTable);
                dataGridView2.DataSource = dataTable;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }




        }

        private void manModul_Load(object sender, EventArgs e)
        {

            getDataComboBox();
            getDataComboBoxO();
            getDataComboBoxM();

            MySqlCommand command = new MySqlCommand("SELECT * FROM chyby", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;

        }
        private void getDataComboBox()
        {
            try
            {
                connection.Open();
                string select;

                select = "SELECT symbolicka_adresa FROM man_nazvy WHERE absolutna_adresa LIKE 'I%'";

                MySqlCommand command1 = new MySqlCommand(select, connection);

                MySqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    cbVstupy.Items.Add(reader1.GetString("symbolicka_adresa"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void getDataComboBoxO()
        {
            try
            {
                connection.Open();
                string select;

                select = "SELECT symbolicka_adresa FROM man_nazvy WHERE absolutna_adresa LIKE 'Q%'";



                MySqlCommand command2 = new MySqlCommand(select, connection);


                MySqlDataReader reader2 = command2.ExecuteReader();


                while (reader2.Read())
                {

                    cbVystupy.Items.Add(reader2.GetString("symbolicka_adresa"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void getDataComboBoxM()
        {
            try
            {
                connection.Open();
                string select;

                select = "SELECT symbolicka_adresa FROM man_nazvy WHERE absolutna_adresa LIKE 'M%'";


                MySqlCommand command3 = new MySqlCommand(select, connection);


                MySqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    cbPamäť.Items.Add(reader3.GetString("symbolicka_adresa"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void cbVstupy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSymbolickaAdresa = cbVstupy.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT man_vstupy.* , man_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM man_vstupy " +
                "INNER JOIN man_nazvy ON man_vstupy.absolutna_adresa = man_nazvy.absolutna_adresa " +
                "WHERE man_nazvy.symbolicka_adresa = @symbolicka_adresa";

                MySqlCommand command1 = new MySqlCommand(select, connection);
                command1.Parameters.AddWithValue("@symbolicka_adresa", selectedSymbolickaAdresa);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss:ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cbVystupy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSymbolickaAdresa = cbVystupy.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT man_vystupy.* , man_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM man_vystupy " +
                "INNER JOIN man_nazvy ON man_vystupy.absolutna_adresa = man_nazvy.absolutna_adresa " +
                "WHERE man_nazvy.symbolicka_adresa = @symbolicka_adresa";

                MySqlCommand command1 = new MySqlCommand(select, connection);
                command1.Parameters.AddWithValue("@symbolicka_adresa", selectedSymbolickaAdresa);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss:ms";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cbPamäť_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSymbolickaAdresa = cbPamäť.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT man_memory.* , man_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM man_memory " +
                "INNER JOIN man_nazvy ON man_memory.absolutna_adresa = man_nazvy.absolutna_adresa " +
                "WHERE man_nazvy.symbolicka_adresa = @symbolicka_adresa";

                MySqlCommand command1 = new MySqlCommand(select, connection);
                command1.Parameters.AddWithValue("@symbolicka_adresa", selectedSymbolickaAdresa);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss:ms";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {


                //Ak je odpoveď Yes
                connection.Open();

                //Sql príkaz pre delete
                string delete = "insert into chyby (snimac1,snimac2,nazov_chyby) values ('" + textBox3.Text + "', '" + textBox2.Text + "','" + textBox4.Text + "')";

                MySqlCommand command = new MySqlCommand(delete, connection);


                command.ExecuteNonQuery();

                string query = "Select * from chyby";
                MySqlCommand command1 = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Chyba pri vytváraní dát");
            }
            finally
            {
                connection.Close();
            }
        }
    

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string novyTextBox1Hodnota = textBox1.Text;
                string novyTextBox2Hodnota = textBox2.Text;
                string novyTextBox3Hodnota = textBox3.Text;
                string novyTextBox4Hodnota = textBox4.Text.ToString();
                //string novyTextBox5Hodnota = textBox5.Text;

                // Pripojenie k databáze
                string connectionString = "server=127.0.0.1 ; user=root; database = bakalarska_praca; password=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Vytvorenie SQL príkazu UPDATE na základe vybraneho ID
                    string query = "UPDATE chyby SET snimac1 = @textBox3, snimac2 = @textBox2, nazov_chyby = @textBox4 WHERE id_chyby = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@textBox1", novyTextBox1Hodnota);
                        command.Parameters.AddWithValue("@textBox2", novyTextBox2Hodnota);
                        command.Parameters.AddWithValue("@textBox3", novyTextBox3Hodnota);
                        command.Parameters.AddWithValue("@textBox4", novyTextBox4Hodnota);
                       // command.Parameters.AddWithValue("@textBox5", novyTextBox5Hodnota);
                        command.Parameters.AddWithValue("@id", id);

                        // Vykonanie SQL príkazu UPDATE
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                // Aktualizácia zobrazených údajov v DataGridView
                dataGridView2.SelectedRows[0].Cells[1].Value = novyTextBox1Hodnota;
                dataGridView2.SelectedRows[0].Cells[2].Value = novyTextBox2Hodnota;
                dataGridView2.SelectedRows[0].Cells[3].Value = novyTextBox3Hodnota;
                dataGridView2.SelectedRows[0].Cells[4].Value = novyTextBox4Hodnota;

                MessageBox.Show("Záznam bol úspešne upravený.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                DialogResult odpoved = MessageBox.Show("Naozaj chcte vymazať chybu s ID: " + textBox1.Text, "Vymazanie používateľa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //Ak je odpoveď Yes
                connection.Open();
                if (odpoved == DialogResult.Yes)
                {
                    //Sql príkaz pre delete
                    string delete = "delete from chyby where id_chyby = " + textBox1.Text;

                    MySqlCommand command = new MySqlCommand(delete, connection);


                    command.ExecuteNonQuery();

                    string query = "Select * from chyby";
                    MySqlCommand command1 = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Chyba pri mazaní dát");
            }
            finally
            {
                connection.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private DataTable GetUpdatedDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            // Establish a connection to your MySQL database
            //MySqlConnection connection = new MySqlConnection("YourConnectionString");

            try
            {
                connection.Open();

                // Create a SQL query to fetch the updated data from the database
                string query = "SELECT * FROM man_vystupy";

                MySqlCommand command = new MySqlCommand(query, connection);

                // Execute the query and fetch the data into a DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the database operation
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }

            return dataTable;
        }


        /*private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Code to refresh the DataGridView's data
            // Fetch the updated data from the database
            DataTable updatedData = GetUpdatedDataFromDatabase();

            // Update the DataGridView's data source
            dataGridView1.DataSource = null; // Clear the existing data source
            dataGridView1.DataSource = updatedData; // Set the updated data as the new data source
        }*/

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataComboBox();
            getDataComboBoxO();
            getDataComboBoxM();

            MySqlCommand command = new MySqlCommand("SELECT * FROM chyby ORDER BY id_chyby DESC", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Blizsie si precitajte o chybe v tabulke";
            string title = "Alarmove hlasenie";
            MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}


