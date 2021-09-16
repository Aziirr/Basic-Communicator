using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(new IPEndPoint(IPAddress.Parse(adres.Text), Convert.ToInt32(port.Value)));
                StreamWriter newSw = new StreamWriter(client.GetStream());
                newSw.WriteLine(login.Text);
                newSw.Flush();
                this.Hide();
                String nazwa = login.Text;
                TCPClient okienko = new TCPClient(login.Text, client, newSw);
                okienko.Show();
            }
            catch
            {
                MessageBox.Show("Zrobiłeś coś źle, spróbuj jeszcze raz");
            }

        }

    }
}
