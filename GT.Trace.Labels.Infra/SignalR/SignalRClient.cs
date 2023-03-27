using GT.Trace.Labels.App.Services;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.SignalR
{
    internal abstract class SignalRClient : IDisposable
    {
        private async Task<bool> ConnectWithRetryAsync(HubConnection connection, CancellationToken token)
        {
            // Keep trying to until we can start or the token is canceled.
            MessageBus.PassMessage($"{_clientName} @ \"{_remoteUrl}\".");
            while (true)
            {
                try
                {
                    await connection.StartAsync(token);
                    MessageBus.PassMessage($"{_clientName} conectado.");
                    return true;
                }
                catch when (token.IsCancellationRequested)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBus.PassMessage($"{_clientName} falló ({ex.Message}), intentando de nuevo en 5 segundos...");
                    await Task.Delay(5000);
                }
            }
        }

        private readonly HubConnection _connection;

        private readonly CancellationTokenSource _cts;

        private readonly string _clientName;

        private readonly string _remoteUrl;

        protected SignalRClient(string clientName, IConfigurationRoot configuration, IMessageBusService messageBus)
        {
            _clientName = clientName;
            MessageBus = messageBus;

            LineCode = configuration.GetSection("LineCode").Value;
            _remoteUrl = configuration.GetSection($"SignalRHubUris:{GetType().Name}").Value;

            _connection = new HubConnectionBuilder()
                .WithAutomaticReconnect()
                .WithUrl(_remoteUrl)
                .Build();

            _cts = new CancellationTokenSource();
        }

        private async Task ConnectionClosed(Exception error)
        {
            MessageBus.PassMessage($"SignalR connection closed [ {error} ].");
            await ConnectWithRetryAsync(_connection, _cts.Token);
            await _connection.StartAsync();
        }

        private Task ConnectionReconnecting(Exception error)
        {
            //Debug.Assert(connection.State == HubConnectionState.Reconnecting);

            // Notify users the connection was lost and the client is reconnecting.
            // Start queuing or dropping messages.
            MessageBus.PassMessage($"{_clientName} reconnecting [ {error} ].");

            return Task.CompletedTask;
        }

        private Task ConnectionReconnected(string connectionID)
        {
            //Debug.Assert(connection.State == HubConnectionState.Connected);

            // Notify users the connection was reestablished.
            // Start dequeuing messages queued while reconnecting if any.
            MessageBus.PassMessage($"{_clientName} reconnected.");

            return Task.CompletedTask;
        }

        public void On(string methodName, Func<Task> handler) => _connection.On(methodName, handler);

        public void On<T1>(string methodName, Func<T1, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2>(string methodName, Func<T1, T2, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2, T3, T4>(string methodName, Func<T1, T2, T3, T4, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2, T3, T4, T5>(string methodName, Func<T1, T2, T3, T4, T5, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2, T3, T4, T5, T6>(string methodName, Func<T1, T2, T3, T4, T5, T6, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2, T3, T4, T5, T6, T7>(string methodName, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) => _connection.On(methodName, handler);

        public void On<T1, T2, T3, T4, T5, T6, T7, T8>(string methodName, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) => _connection.On(methodName, handler);

        protected string LineCode { get; }

        protected IMessageBusService MessageBus { get; }

        public virtual async Task Start()
        {
            _connection.Closed += ConnectionClosed;
            _connection.Reconnecting += ConnectionReconnecting;
            _connection.Reconnected += ConnectionReconnected;

            _ = await ConnectWithRetryAsync(_connection, _cts.Token).ConfigureAwait(false);
        }

        public void Dispose()
        {
            _cts.Cancel();
            Task.Run(() => _connection.DisposeAsync());
        }
    }
}