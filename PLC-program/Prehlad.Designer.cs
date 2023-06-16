namespace PLC_program
{
    partial class Prehlad
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
            this.pouzivatel = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Dgroupbox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pouzivatel)).BeginInit();
            this.data.SuspendLayout();
            this.Dgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pouzivatel
            // 
            this.pouzivatel.AllowUserToAddRows = false;
            this.pouzivatel.AllowUserToDeleteRows = false;
            this.pouzivatel.AllowUserToResizeColumns = false;
            this.pouzivatel.AllowUserToResizeRows = false;
            this.pouzivatel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pouzivatel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pouzivatel.BackgroundColor = System.Drawing.Color.White;
            this.pouzivatel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pouzivatel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.meno,
            this.priezvisko,
            this.username,
            this.userpass});
            this.pouzivatel.Location = new System.Drawing.Point(12, 12);
            this.pouzivatel.Name = "pouzivatel";
            this.pouzivatel.ReadOnly = true;
            this.pouzivatel.RowHeadersVisible = false;
            this.pouzivatel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.pouzivatel.RowTemplate.Height = 28;
            this.pouzivatel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pouzivatel.Size = new System.Drawing.Size(1234, 810);
            this.pouzivatel.TabIndex = 0;
            this.pouzivatel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pouzivatel_CellContentClick);
            this.pouzivatel.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.pouzivatel_RowStateChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID používateľa";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // meno
            // 
            this.meno.DataPropertyName = "meno";
            this.meno.HeaderText = "Meno";
            this.meno.MinimumWidth = 8;
            this.meno.Name = "meno";
            this.meno.ReadOnly = true;
            // 
            // priezvisko
            // 
            this.priezvisko.DataPropertyName = "priezvisko";
            this.priezvisko.HeaderText = "Priezvisko";
            this.priezvisko.MinimumWidth = 8;
            this.priezvisko.Name = "priezvisko";
            this.priezvisko.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Login";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // userpass
            // 
            this.userpass.DataPropertyName = "userpass";
            this.userpass.HeaderText = "Heslo";
            this.userpass.MinimumWidth = 8;
            this.userpass.Name = "userpass";
            this.userpass.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.data.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.data.Controls.Add(this.button3);
            this.data.Controls.Add(this.button1);
            this.data.Controls.Add(this.button2);
            this.data.Controls.Add(this.Dgroupbox);
            this.data.Location = new System.Drawing.Point(1262, 12);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(443, 810);
            this.data.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vymazať";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Upraviť";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dgroupbox
            // 
            this.Dgroupbox.Controls.Add(this.label5);
            this.Dgroupbox.Controls.Add(this.textBox5);
            this.Dgroupbox.Controls.Add(this.label4);
            this.Dgroupbox.Controls.Add(this.label3);
            this.Dgroupbox.Controls.Add(this.label2);
            this.Dgroupbox.Controls.Add(this.label1);
            this.Dgroupbox.Controls.Add(this.textBox4);
            this.Dgroupbox.Controls.Add(this.textBox3);
            this.Dgroupbox.Controls.Add(this.textBox2);
            this.Dgroupbox.Controls.Add(this.textBox1);
            this.Dgroupbox.Location = new System.Drawing.Point(27, 25);
            this.Dgroupbox.Name = "Dgroupbox";
            this.Dgroupbox.Size = new System.Drawing.Size(348, 370);
            this.Dgroupbox.TabIndex = 0;
            this.Dgroupbox.TabStop = false;
            this.Dgroupbox.Text = "Dáta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(154, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(98, 26);
            this.textBox5.TabIndex = 8;
            this.textBox5.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priezvisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meno: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Prehlad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1726, 834);
            this.Controls.Add(this.data);
            this.Controls.Add(this.pouzivatel);
            this.Name = "Prehlad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prehlad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prehlad_FormClosing);
            this.Load += new System.EventHandler(this.Prehlad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pouzivatel)).EndInit();
            this.data.ResumeLayout(false);
            this.Dgroupbox.ResumeLayout(false);
            this.Dgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pouzivatel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel data;
        private System.Windows.Forms.GroupBox Dgroupbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpass;
    }
}