namespace TCPClient
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.adresLabel = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaloguj się";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(175, 93);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(182, 20);
            this.login.TabIndex = 1;
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(135, 126);
            this.adresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(40, 13);
            this.adresLabel.TabIndex = 2;
            this.adresLabel.Text = "Adres: ";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(175, 123);
            this.adres.Margin = new System.Windows.Forms.Padding(2);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(182, 20);
            this.adres.TabIndex = 3;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(140, 165);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(31, 13);
            this.portLabel.TabIndex = 4;
            this.portLabel.Text = "port: ";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(178, 163);
            this.port.Margin = new System.Windows.Forms.Padding(2);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(59, 20);
            this.port.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(144, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Komunikator";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.adresLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}