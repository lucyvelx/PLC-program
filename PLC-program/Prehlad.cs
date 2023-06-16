using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PLC_program
{
    public partial class Prehlad : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; database = bakalarska_praca; password=");
        public Prehlad()
        {
            InitializeComponent();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pouzivatelia", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                pouzivatel.DataSource = dt;   
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App app = new App();    
            app.Show();
            this.Hide();
        }

        private void Prehlad_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pouzivatel_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           if (pouzivatel.SelectedRows.Count > 0)
            {
                textBox5.Text = pouzivatel.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = pouzivatel.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = pouzivatel.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = pouzivatel.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = pouzivatel.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void pouzivatel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 5 && e.RowIndex > -1)
                {
                   textBox5.Text = pouzivatel.Rows[e.RowIndex].Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)

        {
            
            try
            {

                DialogResult odpoved = MessageBox.Show("Naozaj chcte vymazať používateľa s ID: " + textBox5.Text, "Vymazanie používateľa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //Ak je odpoveď Yes
                connection.Open();
                if (odpoved == DialogResult.Yes)
                {
                    //Sql príkaz pre delete
                    string delete = "delete from pouzivatelia where id = " + textBox5.Text;

                    MySqlCommand command = new MySqlCommand(delete, connection);
                   

                    command.ExecuteNonQuery();

                    string query = "Select * from pouzivatelia";
                    MySqlCommand command1 = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command1);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    pouzivatel.DataSource = dt;
                  
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (pouzivatel.SelectedRows.Count > 0)
            {
                string id = pouzivatel.SelectedRows[0].Cells[0].Value.ToString();
                string novyTextBox1Hodnota = textBox1.Text;
                string novyTextBox2Hodnota = textBox2.Text;
                string novyTextBox3Hodnota = textBox3.Text;
                string novyTextBox4Hodnota = textBox4.Text;

                // Pripojenie k databáze
                string connectionString = "server=127.0.0.1 ; user=root; database = bakalarska_praca; password=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Vytvorenie SQL príkazu UPDATE na základe vybraneho ID
                    string query = "UPDATE pouzivatelia SET meno = @textBox1, priezvisko = @textBox2, username = @textBox3, userpass = @textBox4 WHERE ID = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@textBox1", novyTextBox1Hodnota);
                        command.Parameters.AddWithValue("@textBox2", novyTextBox2Hodnota);
                        command.Parameters.AddWithValue("@textBox3", novyTextBox3Hodnota);
                        command.Parameters.AddWithValue("@textBox4", novyTextBox4Hodnota);
                        command.Parameters.AddWithValue("@id", id);

                        // Vykonanie SQL príkazu UPDATE
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                // Aktualizácia zobrazených údajov v DataGridView
                pouzivatel.SelectedRows[0].Cells[1].Value = novyTextBox1Hodnota;
                pouzivatel.SelectedRows[0].Cells[2].Value = novyTextBox2Hodnota;
                pouzivatel.SelectedRows[0].Cells[3].Value = novyTextBox3Hodnota;
                pouzivatel.SelectedRows[0].Cells[4].Value = novyTextBox4Hodnota;

                MessageBox.Show("Záznam bol úspešne upravený.");
            }
        }

        private void Prehlad_FormClosing(object sender, FormClosingEventArgs e)
        {
            App app = new App();
            app.Show(); 
            this.Hide();
        }
    }
}
