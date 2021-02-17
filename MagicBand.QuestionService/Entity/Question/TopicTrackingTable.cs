public class TopicTrackingTable {
    public long TopicTrackingId { get; set; } // PK
    public long BoardTrackingId { get; set; } // FK [1 to Many relationship with Board tracking table]
    public string TopicName { get; set; }
    public string SubTopicName { get; set; }
}