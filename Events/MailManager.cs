using System;

namespace Events
{
    public class NewMailEventArgs : EventArgs
    {
        public string From { get; }
        public string To { get; }
        public string Subject { get; }

        public NewMailEventArgs(string from, string to, string subject)
        {
            From = from;
            To = to;
            Subject = subject;
        }
    }

    public class MailManager
    {
        public EventHandler<NewMailEventArgs> NewMail;

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            e.Raise(this, ref NewMail);
        }

        public void SimulateNewMail(string from, string to, string subject)
        {
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewMail(e);
        }
    }
}
