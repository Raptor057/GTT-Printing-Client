using System;
using System.Collections.Generic;

namespace GT.Trace.PrintingCompanion
{
    public sealed class MessageBus
    {
        private readonly IDictionary<string, IList<object>> _eventListeners = new Dictionary<string, IList<object>>();

        public void Register<T>(string eventName, Action<T> callback)
        {
            if (!_eventListeners.ContainsKey(eventName))
            {
                _eventListeners.Add(eventName, new List<object>() { callback });
            }
        }

        public void Raise<T>(string eventName, T message)
        {
            if (_eventListeners.TryGetValue(eventName, out var callbacks))
            {
                foreach (var callback in callbacks)
                {
                    (callback as Action<T>)(message);
                }
            }
        }
    }
}