namespace login
{
    partial class Form1
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
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.codes = new System.Windows.Forms.Label();
            this.EmpIDbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(525, 339);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 55);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(236, 339);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(144, 55);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(221, 96);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(91, 29);
            this.name.TabIndex = 2;
            this.name.Text = "EmpID";
            // 
            // codes
            // 
            this.codes.AutoSize = true;
            this.codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codes.Location = new System.Drawing.Point(221, 177);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(126, 29);
            this.codes.TabIndex = 3;
            this.codes.Text = "password";
            // 
            // EmpIDbox
            // 
            this.EmpIDbox.Location = new System.Drawing.Point(546, 96);
            this.EmpIDbox.Name = "EmpIDbox";
            this.EmpIDbox.Size = new System.Drawing.Size(212, 26);
            this.EmpIDbox.TabIndex = 4;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(546, 177);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(212, 26);
            this.passwordbox.TabIndex = 5;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.EmpIDbox);
            this.Controls.Add(this.codes);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label codes;
        private System.Windows.Forms.TextBox EmpIDbox;
        private System.Windows.Forms.TextBox passwordbox;
    }
}

