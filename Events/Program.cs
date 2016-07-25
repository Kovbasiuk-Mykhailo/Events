namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager manager = new MailManager();
            Fax fax = new Fax(manager);
            manager.SimulateNewMail("Test", "Test", "Test");
        }
    }
}
