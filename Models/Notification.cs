namespace EventManagementTrialCFA.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int EventId { get; set; }
        public virtual Event? Event { get; set; }
        public String Message { get; set; }
        public TimeOnly SentTime { get; set; }
    }
}
