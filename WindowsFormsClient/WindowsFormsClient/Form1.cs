using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {

        private RemotingObjects.IRemoteObject remoteObject;

        public Form1()
        {
            try
            {
                HttpChannel channel = new HttpChannel();
                //ChannelServices.RegisterChannel(channel, true);
                ChannelServices.RegisterChannel(channel, false);
                remoteObject = (RemotingObjects.IRemoteObject)
                    Activator.GetObject(typeof(RemotingObjects.IRemoteObject),
                    //"tcp://localhost:12000/HostObject"
                    "http://localhost:14000/HostObject");
            }
            catch
            {
                MessageBox.Show("Error connecting to the server");
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (remoteObject != null)
            {
                String result = remoteObject.sayHello(textBox1.Text);
                MessageBox.Show("Result : " + result);
            }
            else
                MessageBox.Show("Error: Remote object not available");
        }
    }
}
