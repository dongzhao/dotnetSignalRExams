namespace SignalRNotificationWeb.Events
{
    /// <summary>
    /// Event pattern subject class follow subject/observer
    /// </summary>
    public class NewRequestSubject
    {
        public event EventHandler eventHandler;

        public void NotifyObservers()
        {
            if(eventHandler != null)
            {
                eventHandler(this, EventArgs.Empty);
            } 
        }

    }
}
