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
    public partial class Inputs : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; database = bakalarska_praca; password=");
        public Inputs()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectNazov = comboBox2.SelectedItem.ToString();
            string selectModule = comboBox1.SelectedItem.ToString();

            try
            {
                connection.Open();

                MySqlCommand command;

                switch (selectNazov)
                {
                    case "Manipulačný modul":
                        switch (selectModule)
                        {
                            case "Vstup":
                                command = new MySqlCommand("SELECT * FROM man_vstupy", connection);
                                break;
                             case "Výstup":
                                command = new MySqlCommand("SELECT * FROM man_vystupy", connection);
                                break;
                            case "Pamäť":
                                command = new MySqlCommand("SELECT * FROM man_memory", connection);
                                break;
                            // Add more cases for different module options if needed
                            default:
                                // Handle unknown module option
                                MessageBox.Show("Unknown module option selected.");
                                return;
                        }
                        break;

                    case "Triediaci modul":
                        switch (selectModule)
                        {
                            case "Vstup":
                                command = new MySqlCommand("SELECT * FROM tr_vstupy", connection);
                                break;
                            case "Výstup":
                                command = new MySqlCommand("SELECT * FROM tr_vystupy", connection);
                                break;
                            case "Pamäť":
                                command = new MySqlCommand("SELECT * FROM tr_memory", connection);
                                break;
                            // Add more cases for different module options if needed
                            default:
                                // Handle unknown module option
                                MessageBox.Show("Unknown module option selected.");
                                return;
                        }
                        break;

                    default:
                        // Handle unknown selectNazov option
                        MessageBox.Show("Unknown selectNazov option selected.");
                        return;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void Inputs_FormClosing(object sender, FormClosingEventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }
    }
}
