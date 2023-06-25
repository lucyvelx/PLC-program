using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_program
{
    public partial class trModul : Form
    {
        public trModul()
        {
            InitializeComponent();
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
                da.Fill(dataTable);
                dataGridView2.DataSource = dataTable;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; Convert Zero Datetime = true ; database = bakalarska_praca; password=");

        private void trModul_Load(object sender, EventArgs e)
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

                select = "SELECT symbolicka_adresa FROM tr_nazvy WHERE absolutna_adresa LIKE 'I%'";

                MySqlCommand command1 = new MySqlCommand(select, connection);

                MySqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    comboBox1.Items.Add(reader1.GetString("symbolicka_adresa"));

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

                select = "SELECT symbolicka_adresa FROM tr_nazvy WHERE absolutna_adresa LIKE 'Q%'";



                MySqlCommand command2 = new MySqlCommand(select, connection);


                MySqlDataReader reader2 = command2.ExecuteReader();


                while (reader2.Read())
                {

                    comboBox2.Items.Add(reader2.GetString("symbolicka_adresa"));

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

                select = "SELECT symbolicka_adresa FROM tr_nazvy WHERE absolutna_adresa LIKE 'M%'";


                MySqlCommand command3 = new MySqlCommand(select, connection);


                MySqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    comboBox3.Items.Add(reader3.GetString("symbolicka_adresa"));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectedSymbolickaAdresa = comboBox1.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT tr_vstupy.* , tr_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM tr_vstupy " +
                "INNER JOIN tr_nazvy ON tr_vstupy.absolutna_adresa = tr_nazvy.absolutna_adresa " +
                "WHERE tr_nazvy.symbolicka_adresa = @symbolicka_adresa";

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectedSymbolickaAdresa = comboBox2.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT tr_vystupy.* , tr_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM tr_vystupy " +
                "INNER JOIN tr_nazvy ON tr_vystupy.absolutna_adresa = tr_nazvy.absolutna_adresa " +
                "WHERE tr_nazvy.symbolicka_adresa = @symbolicka_adresa";

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string selectedSymbolickaAdresa = comboBox3.SelectedItem.ToString();

            try
            {
                connection.Open();
                string select;


                select = "SELECT tr_memory.* , tr_nazvy.symbolicka_adresa AS symbolicka_adresa_nazvy " +
                "FROM tr_memory " +
                "INNER JOIN tr_nazvy ON tr_memory.absolutna_adresa = tr_nazvy.absolutna_adresa " +
                "WHERE tr_nazvy.symbolicka_adresa = @symbolicka_adresa";
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
           
        }

        private void dataGridView2_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                //Ak je odpoveď Yes
                connection.Open();
                
                    //Sql príkaz pre delete
                    string delete = "insert into chyby (snimac1,snimac2,nazov_chyby) values ('"+textBox3.Text+ "', '"+textBox2.Text+ "','"+textBox4.Text+"')";

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

        private void btnRefresh_Click(object sender, EventArgs e)
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
    }
}

