using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    public partial class Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new();
        private int bufferSize { get; set; } = 1024;

        public Server()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the server
        /// </summary>
        private async void Start()
        {
            try
            {
                if (!int.TryParse(txtPort.Text, out var port) || port is < 1 or > 65535 || !IPAddress.TryParse(txtIp.Text, out var ip))
                {
                    AppendMessage("[ERROR]: De ingevulde waardes van het IP-Adres en/of de port is niet valide.");
                    return;
                }

                server = new TcpListener(ip, port);
                server.Start();

                AppendMessage("[INFO]: De server is succesvol gestart.");

                txtIp.Enabled = false;
                txtPort.Enabled = false;
                txtBufferSize.Enabled = false;
                btnServerStart.Visible = false;
                btnServerStop.Visible = true;


                while (true)
                {
                    try
                    {
                        SetBufferSize();
                        TcpClient client = await server.AcceptTcpClientAsync();
                        clients.Add(client);
                        AppendMessage("[INFO]: Er is een nieuwe client verbonden.");
                        ReceiveMessages(client);
                    }
                    catch (Exception)
                    {
                        AppendMessage("[INFO]: De server is succesvol afgesloten.");
                        break;
                    }
                    
                }
            }
            catch (SocketException e)
            {
                AppendMessage("[ERROR]: De gekozen port of IP-Adres is niet beschikbaar.");
            }
        }

        /// <summary>
        /// Opens the server to receive messages from clients.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private async Task ReceiveMessages(TcpClient client)
        {
            while (true)
            {
                byte[] buffer = new byte[bufferSize];
                StringBuilder message = new();

                do
                {
                    var data = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

                    if (data != 0)
                    {
                        message.Append(Encoding.ASCII.GetString(buffer));
                    }
                }
                while (client.GetStream().DataAvailable);

                if (message.ToString() == "")
                {
                    AppendMessage("[INFO]: Er is een client weggegaan.");
                    break;
                }

                SendMessageToClients(message.ToString());
                AppendMessage($"[BERICHT]: {message}");
            }
        }

        /// <summary>
        /// Sets the buffer size based on given text input.
        /// </summary>
        private void SetBufferSize()
        {
            if (!int.TryParse(txtBufferSize.Text, out int inputBufferSize))
            {
                AppendMessage("[INFO]: Het format van de buffergrootte is niet juist, de fallback van 1024 wordt gebruikt.");
                txtBufferSize.Text = "1024";
                return;
            }

            if (inputBufferSize < 1 || inputBufferSize > 65536)
            {
                AppendMessage("[INFO]: De buffergrootte is niet tussen 1 en 65536, de fallback van 1024 wordt gebruikt.");
                txtBufferSize.Text = "1024";
                return;
            }

            bufferSize = inputBufferSize;
        }

        /// <summary>
        /// Adds a message to the list box.
        /// </summary>
        /// <param name="message"></param>
        private void AppendMessage(String message)
        {
            listBoxServer.Items.Add(message);
        }

        private void SendMessageToClients(string message)
        {
            foreach (var client in clients.Where(client => client.Connected))
            {
                NetworkStream stream = client.GetStream();

                if (stream.CanRead)
                {
                    Byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.WriteAsync(data, 0, data.Length);
                }
            }
            
        }

        /// <summary>
        /// Disconnect all clients currently connected.
        /// </summary>
        private void DisconnectAllClients()
        {
          foreach (var client in clients.Where(client => client.Connected))
          {
             client.Close(); 
          }   
        }

        /// <summary>
        /// Stops the server.
        /// </summary>
        private void Stop()
        {
            DisconnectAllClients();
            server.Stop();

            btnServerStop.Visible = false;
            btnServerStart.Visible = true;
            txtIp.Enabled = true;
            txtPort.Enabled = true;
            txtBufferSize.Enabled = true;
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonStopServer_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}