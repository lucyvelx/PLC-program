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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button4, 0, button4.Height);           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pouzivatel pouzivatel = new Pouzivatel();
            pouzivatel.Show();
            this.Hide();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prehlad prehlad = new Prehlad();
            prehlad.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void manipulačnýModulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nazvy nazvy= new Nazvy();
            nazvy.Show();
            this.Hide();
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
          


            DialogResult odpoved = MessageBox.Show("Naozaj chcete zatvoriť aplikáciu?", "Potvrdenie zatvorenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odpoved == DialogResult.No)
            {
                e.Cancel = true;
            }
            

        }

        private void názvyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void triediaciModulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputs inputs= new Inputs();
            inputs.Show();
            this.Hide();
        }
    }
}

