namespace TCPClient
{
    partial class TCPClient
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbCom = new System.Windows.Forms.ListBox();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.msg = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.messageList = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCom
            // 
            this.lbCom.FormattingEnabled = true;
            this.lbCom.Items.AddRange(new object[] {
            "Client"});
            this.lbCom.Location = new System.Drawing.Point(15, 12);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(486, 43);
            this.lbCom.TabIndex = 4;
            this.lbCom.SelectedIndexChanged += new System.EventHandler(this.lbCom_SelectedIndexChanged);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(12, 338);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(362, 60);
            this.msg.TabIndex = 6;
            this.msg.TextChanged += new System.EventHandler(this.msg_TextChanged);
            this.msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msg_KeyDown);
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.send.Location = new System.Drawing.Point(397, 338);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(104, 60);
            this.send.TabIndex = 7;
            this.send.Text = "Wyślij";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // messageList
            // 
            this.messageList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.messageList.ContextMenuStrip = this.contextMenuStrip1;
            this.messageList.IsWebBrowserContextMenuEnabled = false;
            this.messageList.Location = new System.Drawing.Point(12, 94);
            this.messageList.MinimumSize = new System.Drawing.Size(20, 20);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(489, 209);
            this.messageList.TabIndex = 8;
            this.messageList.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.messageList_DocumentCompleted_1);
            this.messageList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messageList_ControlAdded);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.Location = new System.Drawing.Point(16, 309);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "B";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(97, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "I";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(397, 60);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 28);
            this.button7.TabIndex = 15;
            this.button7.Text = "Zmiana serwera";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Polecenia: /active , /priv , /time , /nick\r\n";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(178, 309);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "u";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(513, 411);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.send);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.lbCom);
            this.Name = "TCPClient";
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCom;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button send;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.Windows.Forms.WebBrowser messageList;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
    }
}

