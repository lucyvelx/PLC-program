namespace PLC_program
{
    partial class manModul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolicka_adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absolutna_adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVstupy = new System.Windows.Forms.ComboBox();
            this.cbVystupy = new System.Windows.Forms.ComboBox();
            this.cbPamäť = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_chyby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snimac1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snimac2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazov_chyby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cas_chyby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.symbolicka_adresa,
            this.absolutna_adresa,
            this.hodnota,
            this.cas});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(620, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 474);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID merania";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // symbolicka_adresa
            // 
            this.symbolicka_adresa.DataPropertyName = "symbolicka_adresa_nazvy";
            this.symbolicka_adresa.HeaderText = "Symbolická adresa";
            this.symbolicka_adresa.MinimumWidth = 8;
            this.symbolicka_adresa.Name = "symbolicka_adresa";
            this.symbolicka_adresa.ReadOnly = true;
            // 
            // absolutna_adresa
            // 
            this.absolutna_adresa.DataPropertyName = "absolutna_adresa";
            this.absolutna_adresa.HeaderText = "Absolútna adresa";
            this.absolutna_adresa.MinimumWidth = 8;
            this.absolutna_adresa.Name = "absolutna_adresa";
            this.absolutna_adresa.ReadOnly = true;
            // 
            // hodnota
            // 
            this.hodnota.DataPropertyName = "hodnota";
            this.hodnota.HeaderText = "Hodnota";
            this.hodnota.MinimumWidth = 8;
            this.hodnota.Name = "hodnota";
            this.hodnota.ReadOnly = true;
            // 
            // cas
            // 
            this.cas.DataPropertyName = "cas";
            this.cas.HeaderText = "Čas";
            this.cas.MinimumWidth = 8;
            this.cas.Name = "cas";
            this.cas.ReadOnly = true;
            // 
            // cbVstupy
            // 
            this.cbVstupy.FormattingEnabled = true;
            this.cbVstupy.Location = new System.Drawing.Point(49, 77);
            this.cbVstupy.Name = "cbVstupy";
            this.cbVstupy.Size = new System.Drawing.Size(340, 28);
            this.cbVstupy.TabIndex = 1;
            this.cbVstupy.SelectedIndexChanged += new System.EventHandler(this.cbVstupy_SelectedIndexChanged);
            // 
            // cbVystupy
            // 
            this.cbVystupy.FormattingEnabled = true;
            this.cbVystupy.Location = new System.Drawing.Point(49, 174);
            this.cbVystupy.Name = "cbVystupy";
            this.cbVystupy.Size = new System.Drawing.Size(340, 28);
            this.cbVystupy.TabIndex = 2;
            this.cbVystupy.SelectedIndexChanged += new System.EventHandler(this.cbVystupy_SelectedIndexChanged);
            // 
            // cbPamäť
            // 
            this.cbPamäť.FormattingEnabled = true;
            this.cbPamäť.Location = new System.Drawing.Point(49, 280);
            this.cbPamäť.Name = "cbPamäť";
            this.cbPamäť.Size = new System.Drawing.Size(340, 28);
            this.cbPamäť.TabIndex = 3;
            this.cbPamäť.SelectedIndexChanged += new System.EventHandler(this.cbPamäť_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vstup (Input):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Výstup (Output) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pamäť (Memory) :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_chyby,
            this.snimac1,
            this.snimac2,
            this.nazov_chyby,
            this.cas_chyby});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2.Location = new System.Drawing.Point(620, 546);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1060, 488);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // id_chyby
            // 
            this.id_chyby.DataPropertyName = "id_chyby";
            this.id_chyby.HeaderText = "ID chyby";
            this.id_chyby.MinimumWidth = 8;
            this.id_chyby.Name = "id_chyby";
            // 
            // snimac1
            // 
            this.snimac1.DataPropertyName = "snimac1";
            this.snimac1.HeaderText = "Začiatočný snímač";
            this.snimac1.MinimumWidth = 8;
            this.snimac1.Name = "snimac1";
            // 
            // snimac2
            // 
            this.snimac2.DataPropertyName = "snimac2";
            this.snimac2.HeaderText = "Koncový snímač";
            this.snimac2.MinimumWidth = 8;
            this.snimac2.Name = "snimac2";
            // 
            // nazov_chyby
            // 
            this.nazov_chyby.DataPropertyName = "nazov_chyby";
            this.nazov_chyby.HeaderText = "Názov chyby";
            this.nazov_chyby.MinimumWidth = 8;
            this.nazov_chyby.Name = "nazov_chyby";
            // 
            // cas_chyby
            // 
            this.cas_chyby.DataPropertyName = "cas_chyby";
            this.cas_chyby.HeaderText = "Čas";
            this.cas_chyby.MinimumWidth = 8;
            this.cas_chyby.Name = "cas_chyby";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 2713);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(28, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 504);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chyby";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 51);
            this.button3.TabIndex = 25;
            this.button3.Text = "Vymazať";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(195, 291);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 26);
            this.textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(330, 26);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Čas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Názov chyby";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Koncový snímač";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Začiatočný snímač";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID chyby";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "Upraviť";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Pridať";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVstupy);
            this.groupBox1.Controls.Add(this.cbVystupy);
            this.groupBox1.Controls.Add(this.cbPamäť);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dáta";
            // 
            // manModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1703, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manipulačný modul";
            this.Load += new System.EventHandler(this.manModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbVstupy;
        private System.Windows.Forms.ComboBox cbVystupy;
        private System.Windows.Forms.ComboBox cbPamäť;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolicka_adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn absolutna_adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodnota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cas;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chyby;
        private System.Windows.Forms.DataGridViewTextBoxColumn snimac1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snimac2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazov_chyby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cas_chyby;
    }
}