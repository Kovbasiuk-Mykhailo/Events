using System;
using System.Threading;

namespace Events
{
    public static class EventArgEtensions
    {
        public static void Raise<TEventArgs>(this TEventArgs e, object sender,
            ref EventHandler<TEventArgs> eventDelegate)
        {
            EventHandler<TEventArgs> temp = Volatile.Read(ref eventDelegate);
            temp?.Invoke(sender, e);
        }
    }
}
