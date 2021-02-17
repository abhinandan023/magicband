public class  Question
{
    public long Id { get; set; }
    public int QuestionTypeId  { get; set; } //FK
    public ulong QuestionOwnerId { get; set; } // FK from user table
    public string TitleText { get; set; }
    public string ImageUrls{ get; set; }
    public List<IOption> Options  { get; set; }
    public List<string> Tags { get; set; }

    // contains the data structure to hold the Difficulty Level per board per grade
    public List<IDifficultyLevel> DifficultyLevel { get; set; } 
}