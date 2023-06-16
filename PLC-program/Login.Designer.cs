namespace PLC_program
{
    partial class Login
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
            this.log_in = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbHeslo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPaswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.LightBlue;
            this.log_in.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.log_in.Location = new System.Drawing.Point(97, 241);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(162, 56);
            this.log_in.TabIndex = 0;
            this.log_in.Text = "Prihlásiť";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel.Location = new System.Drawing.Point(293, 241);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(186, 56);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Zrušiť";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(93, 97);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(56, 20);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login: ";
            // 
            // lbHeslo
            // 
            this.lbHeslo.AutoSize = true;
            this.lbHeslo.Location = new System.Drawing.Point(93, 160);
            this.lbHeslo.Name = "lbHeslo";
            this.lbHeslo.Size = new System.Drawing.Size(54, 20);
            this.lbHeslo.TabIndex = 3;
            this.lbHeslo.Text = "Heslo:";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbLogin.Location = new System.Drawing.Point(200, 94);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(279, 26);
            this.tbLogin.TabIndex = 4;
            // 
            // tbPaswd
            // 
            this.tbPaswd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPaswd.Location = new System.Drawing.Point(200, 157);
            this.tbPaswd.Name = "tbPaswd";
            this.tbPaswd.PasswordChar = '*';
            this.tbPaswd.Size = new System.Drawing.Size(279, 26);
            this.tbPaswd.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 369);
            this.Controls.Add(this.tbPaswd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbHeslo);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.log_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prihlásenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbHeslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPaswd;
    }
}

