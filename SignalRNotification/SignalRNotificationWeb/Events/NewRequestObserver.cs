namespace SignalRNotificationWeb.Events
{
    /// <summary>
    /// Observer pattern using event: An observer class 
    /// </summary>
    public class NewRequestObserver
    {
        NewRequestSubject subject;

        public NewRequestObserver(NewRequestSubject sub)
        {
            this.subject = sub;
        }

        public void Subscribe()
        {
            subject.eventHandler += SendToHub;
        }

        private void SendToHub(object sender, EventArgs e)
        {
            Console.WriteLine("calling signal....");
        }
    }
}
