namespace FlexerApp
{
    partial class FlexerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexerApp));
            this.LoginControl = new System.Windows.Forms.Button();
            this.ExitControl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasswordCaptionControl = new System.Windows.Forms.Label();
            this.EmailCaptionControl = new System.Windows.Forms.Label();
            this.EmailControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIconControl = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // LoginControl
            // 
            this.LoginControl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.LoginControl.Location = new System.Drawing.Point(191, 12);
            this.LoginControl.Name = "LoginControl";
            this.LoginControl.Size = new System.Drawing.Size(160, 80);
            this.LoginControl.TabIndex = 0;
            this.LoginControl.Text = "Login";
            this.LoginControl.UseVisualStyleBackColor = true;
            this.LoginControl.Click += new System.EventHandler(this.LoginControl_Click);
            // 
            // ExitControl
            // 
            this.ExitControl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitControl.Location = new System.Drawing.Point(191, 101);
            this.ExitControl.Name = "ExitControl";
            this.ExitControl.Size = new System.Drawing.Size(160, 80);
            this.ExitControl.TabIndex = 1;
            this.ExitControl.Text = "Exit";
            this.ExitControl.UseVisualStyleBackColor = true;
            this.ExitControl.Click += new System.EventHandler(this.ExitControl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // PasswordCaptionControl
            // 
            this.PasswordCaptionControl.AutoSize = true;
            this.PasswordCaptionControl.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.PasswordCaptionControl.ForeColor = System.Drawing.Color.SpringGreen;
            this.PasswordCaptionControl.Location = new System.Drawing.Point(12, 129);
            this.PasswordCaptionControl.Name = "PasswordCaptionControl";
            this.PasswordCaptionControl.Size = new System.Drawing.Size(68, 18);
            this.PasswordCaptionControl.TabIndex = 3;
            this.PasswordCaptionControl.Text = "Password";
            // 
            // EmailCaptionControl
            // 
            this.EmailCaptionControl.AutoSize = true;
            this.EmailCaptionControl.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailCaptionControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailCaptionControl.Location = new System.Drawing.Point(12, 80);
            this.EmailCaptionControl.Name = "EmailCaptionControl";
            this.EmailCaptionControl.Size = new System.Drawing.Size(42, 18);
            this.EmailCaptionControl.TabIndex = 5;
            this.EmailCaptionControl.Text = "Email";
            // 
            // EmailControl
            // 
            this.EmailControl.Location = new System.Drawing.Point(12, 101);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(170, 20);
            this.EmailControl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flexer App";
            // 
            // notifyIconControl
            // 
            this.notifyIconControl.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconControl.Icon")));
            this.notifyIconControl.Text = "FlexerApp";
            // 
            // FlexerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(363, 193);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailCaptionControl);
            this.Controls.Add(this.EmailControl);
            this.Controls.Add(this.PasswordCaptionControl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExitControl);
            this.Controls.Add(this.LoginControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FlexerApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlexerApp_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginControl;
        private System.Windows.Forms.Button ExitControl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PasswordCaptionControl;
        private System.Windows.Forms.Label EmailCaptionControl;
        private System.Windows.Forms.TextBox EmailControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIconControl;
    }
}

