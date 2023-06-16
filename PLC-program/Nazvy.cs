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
    public partial class Nazvy : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; database = bakalarska_praca; password=");
        public Nazvy()
        {
            InitializeComponent();
        }

        private void Nazvy_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectNazov = comboBox1.SelectedItem.ToString();
            try
            {
                connection.Open();  
                if (selectNazov == "Manipulačný modul")
                {
                    //this.dataGridView1.DataSource = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM man_nazvy",connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                else if (selectNazov == "Triediaci modul")
                {
                    this.dataGridView1.DataSource = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM tr_nazvy", connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            { 
              connection.Close(); 
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e.ColumnIndex == 0  && e.RowIndex > -1)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string selectNazov = comboBox1.SelectedItem.ToString();
            if (selectNazov == "Manipulačný modul")
            {


                if (dataGridView1.SelectedRows.Count > 0)
                {
                    //string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string novyTextBox1Hodnota = textBox1.Text;
                    string novyTextBox2Hodnota = textBox2.Text;


                    // Pripojenie k databáze
                    string connectionString = "server=127.0.0.1 ; user=root; database = bakalarska_praca; password=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Vytvorenie SQL príkazu UPDATE na základe vybraneho ID
                        string query = "UPDATE man_nazvy SET symbolicka_adresa = @textBox2 Where absolutna_adresa = @textBox1 ";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@textBox1", novyTextBox1Hodnota);
                            command.Parameters.AddWithValue("@textBox2", novyTextBox2Hodnota);
                            //command.Parameters.AddWithValue("@id", id);


                            // Vykonanie SQL príkazu UPDATE
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }

                    // Aktualizácia zobrazených údajov v DataGridView
                    //dataGridView1.SelectedRows[0].Cells[0].Value = novyTextBox1Hodnota;
                    dataGridView1.SelectedRows[0].Cells[1].Value = novyTextBox2Hodnota;


                    MessageBox.Show("Záznam bol úspešne upravený.");
                }
                else if (selectNazov == "Triediaci modul")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        //string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string novyTextBox1Hodnota = textBox1.Text;
                        string novyTextBox2Hodnota = textBox2.Text;


                        // Pripojenie k databáze
                        string connectionString = "server=127.0.0.1 ; user=root; database = bakalarska_praca; password=";
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Vytvorenie SQL príkazu UPDATE na základe vybraneho ID
                            string query = "UPDATE tr_nazvy SET symbolicka_adresa = @textBox2 Where absolutna_adresa = @textBox1 ";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@textBox1", novyTextBox1Hodnota);
                                command.Parameters.AddWithValue("@textBox2", novyTextBox2Hodnota);
                                //command.Parameters.AddWithValue("@id", id);


                                // Vykonanie SQL príkazu UPDATE
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                        }

                        // Aktualizácia zobrazených údajov v DataGridView
                        //dataGridView1.SelectedRows[0].Cells[0].Value = novyTextBox1Hodnota;
                        dataGridView1.SelectedRows[0].Cells[1].Value = novyTextBox2Hodnota;


                        MessageBox.Show("Záznam bol úspešne upravený.");

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string selectNazov = comboBox1.SelectedItem.ToString();
                if (selectNazov == "Manipulačný modul")
                {

                    DialogResult odpoved = MessageBox.Show("Naozaj chcete vymazať názov " + textBox1.Text, "Vymazanie názvu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    //Ak je odpoveď Yes
                    connection.Open();
                    if (odpoved == DialogResult.Yes)
                    {
                        //Sql príkaz pre delete
                        string delete = "delete from man_nazvy where absolutna_adresa = @textBox1";

                        MySqlCommand command = new MySqlCommand(delete, connection);
                        command.Parameters.AddWithValue("@textBox1", textBox1.Text);

                       
                        command.ExecuteNonQuery();

                        string query = "Select * from man_nazvy";
                        MySqlCommand command1 = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                    }
                }
                else if (selectNazov == "Triediaci modul")
                {
                    DialogResult odpoved = MessageBox.Show("Naozaj chcete vymazať názov " + textBox1.Text, "Vymazanie názvu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    //Ak je odpoveď Yes
                   
                    if (odpoved == DialogResult.Yes)
                    {
                        //Sql príkaz pre delete
                        string delete = "delete from tr_nazvy where absolutna_adresa = @textBox1";

                        MySqlCommand command = new MySqlCommand(delete, connection);
                        command.Parameters.AddWithValue("@textBox1", textBox1.Text);

                        connection.Open();
                        command.ExecuteNonQuery();

                        string query = "Select * from tr_nazvy";
                        MySqlCommand command1 = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                    }
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
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           string modul =  comboBox1.SelectedItem.ToString();
            if (modul == "Manipulačný modul")
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("Insert into man_nazvy (absolutna_adresa,symbolicka_adresa) values ('" + textBox3.Text + "','" + textBox4.Text + "')", connection);



                    //command.ExecuteNonQuery();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Názov bol vytvorený.");
                    }


                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
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
            else if (modul == "Triediaci modul")
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("Insert into tr_nazvy (absolutna_adresa,symbolicka_adresa) values ('" + textBox3.Text + "','" + textBox4.Text + "')", connection);



                    //command.ExecuteNonQuery();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Názov bol vytvorený.");
                    }


                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
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

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nazvy_FormClosing(object sender, FormClosingEventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }
    }
}
