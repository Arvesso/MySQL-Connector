namespace SQLconnector
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLastNameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.userLastNameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 451);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // userLastNameField
            // 
            this.userLastNameField.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLastNameField.Location = new System.Drawing.Point(391, 239);
            this.userLastNameField.MaxLength = 10;
            this.userLastNameField.Name = "userLastNameField";
            this.userLastNameField.ShortcutsEnabled = false;
            this.userLastNameField.Size = new System.Drawing.Size(273, 50);
            this.userLastNameField.TabIndex = 7;
            this.userLastNameField.Enter += new System.EventHandler(this.userLastNameField_Enter);
            this.userLastNameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userLastNameField_KeyDown);
            this.userLastNameField.Leave += new System.EventHandler(this.userLastNameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(391, 147);
            this.userNameField.MaxLength = 10;
            this.userNameField.Name = "userNameField";
            this.userNameField.ShortcutsEnabled = false;
            this.userNameField.Size = new System.Drawing.Size(273, 50);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameField_KeyDown);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(43)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(114)))), ((int)(((byte)(91)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(78)))), ((int)(((byte)(9)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(9)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(466, 350);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(198, 42);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(62, 239);
            this.passwordField.MaxLength = 10;
            this.passwordField.Name = "passwordField";
            this.passwordField.ShortcutsEnabled = false;
            this.passwordField.Size = new System.Drawing.Size(273, 50);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordField_KeyDown);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(62, 147);
            this.loginField.MaxLength = 10;
            this.loginField.Name = "loginField";
            this.loginField.ShortcutsEnabled = false;
            this.loginField.Size = new System.Drawing.Size(273, 50);
            this.loginField.TabIndex = 3;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginField_KeyDown);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userLastNameField;
        private System.Windows.Forms.TextBox userNameField;
    }
}