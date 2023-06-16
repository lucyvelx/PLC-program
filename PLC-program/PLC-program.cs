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
    public partial class PLC_program : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public PLC_program()
        {
            InitializeComponent();
            timer.Interval = 1000;

            // Pridanie obslužnej metódy pre udalosť Tick
           // timer.Tick += new EventHandler(timer1_Tick);

            // Spustenie timeru
            timer.Start();
        }

        private void manModul_Click(object sender, EventArgs e)
        {
            manModul f2 = new manModul();
            f2.Show();
            //this.Hide();
        }

        private void trModul_Click(object sender, EventArgs e)
        {
            trModul f3 = new trModul();
            f3.Show();
            //this.Hide();
        }

       
            /*
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
                    trValue = reader.GetBoolean(0);
                }
            }

            TimeSpan difference = timestamp1 - timestamp2;
            double seconds = difference.TotalSeconds;

            if (!trValue && seconds > 5)
            {
                MessageBox.Show("Manipulátor nepreniesol výrobok na pás.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySqlCommand command3 = new MySqlCommand("INSERT INTO chyby (snimac1, snimac2) VALUES ('I136.5', 'I136.0')", connection);
                command3.ExecuteNonQuery();
            }*/

          //  connection.Close();





            /*DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM chyby ", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);*/

            
        }

        
    }


