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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void vstupyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Location = new Point(100, 100);
            dataGridView1.Size = new Size(300, 200);

            // Nastavte dáta pre DataGridView (napr. z databázy, zoznamu atď.)
           // dataGridView1.DataSource = GetData();

            // Pridajte DataGridView do formulára
            this.Controls.Add(dataGridView1);
        }

        private void manipulačnýModulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void výstupyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Location = new Point(100, 150);
            dataGridView1.Size = new Size(300, 200);

            // Nastavte dáta pre DataGridView (napr. z databázy, zoznamu atď.)
            // dataGridView1.DataSource = GetData();

            // Pridajte DataGridView do formulára
            this.Controls.Add(dataGridView1);
        }
    }
    }

