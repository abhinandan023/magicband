public class BoardTrackingTable{
    public long BoardTrackingId { get; set; } // PK
    public int BoardId { get; set; } // FK
    public int GradeId { get; set; } // FK
}