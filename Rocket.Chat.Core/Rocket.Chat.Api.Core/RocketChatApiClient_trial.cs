using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApiClient_trial
    {
        void Connect();
        event EventHandler<object> Received;
    }

    public class RocketChatApiClient_trial : IRocketChatApiClient_trial
    {
        public ILogger Logger = Log.Logger;

        public event EventHandler<object> Received;

        private readonly WebSocket _socket;
        private readonly int _port;

        public RocketChatApiClient_trial(string host, int port)
        {
            _port = port;
            var uri = new Uri(host).ToString();
            _socket = new WebSocket(uri);
        }

        private void Initialize()
        {
        }

        public void Connect()
        {
            try
            {
                _socket.MessageReceived += (sender, args) => ReceiveAsync(sender, args);
                bool result = Task.Run(async () => await _socket.OpenAsync()).Result;
                var a = _socket;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private void OnConnected(SocketAsyncEventArgs args)
        //{
           
        //}

        private void ReceiveAsync(object sender, MessageReceivedEventArgs args)
        {
            try
            {
                var a = args;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}