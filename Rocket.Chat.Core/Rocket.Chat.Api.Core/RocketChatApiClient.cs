using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApiClient
    {
        bool Connect();
        event EventHandler<object> Received;
    }

    public class RocketChatApiClient : IRocketChatApiClient
    {
        public ILogger Logger = Log.Logger;

        public event EventHandler<object> Received;

        private const int BUFFER_SIZE = 64;

        private readonly byte[] _buffer;
        private readonly SocketAsyncEventArgs _listener = new SocketAsyncEventArgs();

        private readonly IPAddress _address;
        private readonly Socket _socket;
        private readonly int _port;

        public RocketChatApiClient(string host, int port)
        {
            _port = port;
            _address = IPAddress.Parse(host);
            _socket = new Socket(_address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            _buffer = new byte[BUFFER_SIZE];
        }

        private void Initialize()
        {
        }

        public bool Connect()
        {
            var connectArgs = new SocketAsyncEventArgs { RemoteEndPoint = new IPEndPoint(_address, _port) };
            connectArgs.Completed += (o, e) => OnConnected(e);
            return _socket.ConnectAsync(connectArgs);
        }

        private void OnConnected(SocketAsyncEventArgs args)
        {
            ReceiveAsync();

            //try
            //{
            //    lock (_encryptedStreamSyncRoot)
            //    {
            //        var sendArgs = new SocketAsyncEventArgs();
            //        var buffer = GetInitBuffer();
            //        sendArgs.SetBuffer(buffer, 0, buffer.Length);
            //        sendArgs.Completed += (o, e) =>
            //        {
            //            callback?.Invoke();
            //            e.Dispose();
            //        };
            //        _socket.SendAsync(sendArgs);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Logger.Error(ex, "Socket.OnConnected");
            //}
        }

        private void ReceiveAsync()
        {
            if (_socket == null)
                throw new NullReferenceException("Socket is null");

            if (_socket.Connected)
            {
                try
                {
                    _socket.ReceiveAsync(_listener);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "Socket.ReceiveAsync ReceiveAsync");

                    if (ex is ObjectDisposedException)
                        return;
                }
            }
        }
    }
}