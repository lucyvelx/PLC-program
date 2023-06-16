using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PLC_program
{
    public partial class Login : Form
    {
        public static class Globals
            {
            public static string role;
            }
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1 ; user=root; database = bakalarska_praca; password=");


        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Button Prihlásiť
        private void log_in_Click(object sender, EventArgs e)
        {
            string username, userpass;

            username = tbLogin.Text;
            userpass= tbPaswd.Text;

            try
            {
                //get username and userpass from database
                string query = "SELECT username,userpass FROM pouzivatelia WHERE username = '"+tbLogin.Text+"'AND userpass='"+tbPaswd.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                DataTable dataTable= new DataTable();   
                sda.Fill(dataTable);
                Globals.role = query.ExecuteScalar();

                if (dataTable.Rows.Count > 0)
                {
                    username = tbLogin.Text;    
                    userpass = tbPaswd.Text;

                    //page that needed to be loaded next 

                    PLC_program program = new PLC_program();
                    program.Show();
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Nepodarilo sa prihlásiť.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);


                    tbLogin.Clear();
                    tbPaswd.Clear();

                    tbLogin.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close(); 
            }
        }

        //Button zrušiť
        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Naozaj chcete zavrieť aplikáciu?","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
               Application.Exit();  
            }
            else
            {
                this.Show();
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login= new Login();   
            login.Close();
            App app= new App();
            app.Show();
        }
    }
}
