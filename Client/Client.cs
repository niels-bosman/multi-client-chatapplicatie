using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WIN___Chat_Applicatie
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream networkStream;
        private int bufferSize { get; set; } = 1024;

        public Client()
        {
            InitializeComponent();
            btnClientSend.Enabled = false;
        }

        /// <summary>
        /// Set's the buffer size.
        /// </summary>
        private void SetBufferSize()
        {
            int bufferSize;

            if (!int.TryParse(txtBufferSize.Text, out bufferSize))
            {
                AppendMessage("[ERROR]: Het format van de buffergrootte is niet juist, de fallback van 1024 wordt gebruikt.");
                txtBufferSize.Text = "1024";
                return;
            }

            if (bufferSize < 1 || bufferSize > 65536)
            {
                AppendMessage("[ERROR]: De buffergrootte is niet tussen 1 en 65536, de fallback van 1024 wordt gebruikt.");
                txtBufferSize.Text = "1024";
                return;
            }

            this.bufferSize = bufferSize;
        }

        /// <summary>
        /// Connects to the server based on given inputs.
        /// </summary>
        private async void ConnectToServer()
        {
            try
            {
                if (!int.TryParse(txtClientPort.Text, out int port) || !IPAddress.TryParse(txtClientIp.Text, out IPAddress ip))
                {
                    AppendMessage("[ERROR]: De ingevulde waardes van het IP-Adres en/of de port is niet valide.");
                    return;
                }

                SetBufferSize();
                client = new TcpClient();
                await client.ConnectAsync(ip, port);

                networkStream = client.GetStream();

                AppendMessage("[INFO]: Succesvol met de chat-server verbonden.");

                btnClientSend.Enabled = true;
                txtClientIp.Enabled = false;
                txtClientPort.Enabled = false;
                txtBufferSize.Enabled = false;
                txtClientSend.Enabled = true;
                btnClientSend.Enabled = true;
                btnClientJoin.Visible = false;
                btnClientLeave.Visible = true;

                await ReceiveMessages();

            }
            catch (Exception e)
            {
                client.Close();
                AppendMessage("[ERROR]: Er is wat mis gegaan tijdens het verbinden met de server.");
            }
        }

        /// <summary>
        /// Transmits a message to the server.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private async Task TransmitToServer(String message)
        {
            if (!client.Connected || !networkStream.CanWrite || message == "")
            {
                return;
            }

            try
            {
                var data = Encoding.ASCII.GetBytes(message);
                await networkStream.WriteAsync(data, 0, data.Length);

                if (message.ToLower() == "bye")
                {
                    DisconnectFromServer();
                }

                txtClientSend.Text = "";
            }
            catch
            {
                AppendMessage("[ERROR]: Je kan geen bericht versturen want je bent nog niet met een chat-server verbonden.");
            }
        }

        /// <summary>
        /// Adds a message to the list box.
        /// </summary>
        /// <param name="message"></param>
        private void AppendMessage(string message)
        {
            lsbClient.Items.Add(message);
        }

        /// <summary>
        /// Opens the client up to receive messages from the server.
        /// </summary>
        /// <returns></returns>
        private async Task ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    var buffer = new byte[bufferSize];
                    var message = new StringBuilder();

                    do
                    {
                        var data = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

                        if (data == 0)
                        {
                            client.Close();
                            break;
                        }

                        message.Append(Encoding.ASCII.GetString(buffer));
                    } while (client.GetStream().DataAvailable);

                    if (message.ToString() != "")
                    {
                        AppendMessage($"[BERICHT]: {message}");
                    }
                }
            }
            catch
            {
                DisconnectFromServer();
            }
        }

        /// <summary>
        /// Disconnects the client from the server.
        /// </summary>
        private void DisconnectFromServer()
        {
            client.Close();
            AppendMessage($"[INFO]: De verbindig met de server is verbroken.");

            txtClientIp.Enabled = true;
            txtClientPort.Enabled = true;
            txtBufferSize.Enabled = true;
            btnClientJoin.Visible = true;
            btnClientLeave.Visible = false;
        }

        private async void buttonSendMessage_Click(object sender, EventArgs e)
        {
            await TransmitToServer(txtClientSend.Text);
        }

        private void buttonConnectToServer_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void buttonDisconnectFromServer_Click(object sender, EventArgs e)
        {
            client.Close();
            btnClientSend.Enabled = false;
        }
    }
}