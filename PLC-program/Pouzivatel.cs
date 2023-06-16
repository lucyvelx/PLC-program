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
using System.Windows.Input;

namespace PLC_program
{
    public partial class Pouzivatel : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; database = bakalarska_praca; password=");

        public Pouzivatel()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                MySqlCommand command = new MySqlCommand("Insert into pouzivatelia (meno,priezvisko,username,userpass) values ('"+textBox1.Text+ "','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')", connection);
              
                
       
                //command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Používateľ bol vytvorený.");
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

        private void Pouzivatel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void Pouzivatel_FormClosing(object sender, FormClosingEventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }
    }
}
