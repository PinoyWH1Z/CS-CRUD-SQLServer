namespace CS_CRUD_SQLServer
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
            this.txt_loginID = new System.Windows.Forms.TextBox();
            this.txt_loginPW = new System.Windows.Forms.TextBox();
            this.lbl_loginID = new System.Windows.Forms.Label();
            this.lbl_loginPW = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_loginID
            // 
            this.txt_loginID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_loginID.Location = new System.Drawing.Point(73, 25);
            this.txt_loginID.MaxLength = 21;
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.Size = new System.Drawing.Size(161, 20);
            this.txt_loginID.TabIndex = 0;
            this.txt_loginID.TextChanged += new System.EventHandler(this.txt_loginID_TextChanged);
            this.txt_loginID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loginID_KeyPress);
            // 
            // txt_loginPW
            // 
            this.txt_loginPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_loginPW.Location = new System.Drawing.Point(73, 51);
            this.txt_loginPW.MaxLength = 21;
            this.txt_loginPW.Name = "txt_loginPW";
            this.txt_loginPW.PasswordChar = '*';
            this.txt_loginPW.Size = new System.Drawing.Size(161, 20);
            this.txt_loginPW.TabIndex = 1;
            this.txt_loginPW.TextChanged += new System.EventHandler(this.txt_loginPW_TextChanged);
            this.txt_loginPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loginPW_KeyPress);
            // 
            // lbl_loginID
            // 
            this.lbl_loginID.AutoSize = true;
            this.lbl_loginID.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_loginID.Location = new System.Drawing.Point(43, 28);
            this.lbl_loginID.Name = "lbl_loginID";
            this.lbl_loginID.Size = new System.Drawing.Size(18, 13);
            this.lbl_loginID.TabIndex = 2;
            this.lbl_loginID.Text = "ID";
            // 
            // lbl_loginPW
            // 
            this.lbl_loginPW.AutoSize = true;
            this.lbl_loginPW.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_loginPW.Location = new System.Drawing.Point(43, 54);
            this.lbl_loginPW.Name = "lbl_loginPW";
            this.lbl_loginPW.Size = new System.Drawing.Size(25, 13);
            this.lbl_loginPW.TabIndex = 3;
            this.lbl_loginPW.Text = "PW";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(73, 88);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(161, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(276, 136);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_loginPW);
            this.Controls.Add(this.lbl_loginID);
            this.Controls.Add(this.txt_loginPW);
            this.Controls.Add(this.txt_loginID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(296, 179);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_loginID;
        private System.Windows.Forms.TextBox txt_loginPW;
        private System.Windows.Forms.Label lbl_loginID;
        private System.Windows.Forms.Label lbl_loginPW;
        private System.Windows.Forms.Button btn_Login;
    }
}

