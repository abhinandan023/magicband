public interface IDifficultyLevel
{
    public int BoardId { get; set; }
    public List<IBoardDifficultyLevel> Boards { get; set; }
}

interface IBoardDifficultyLevel
{
    public string BoardName { get; set; }
    public List<IGradeDifficultyLevel> Grades { get; set; }
}

interface IGradeDifficultyLevel
{
    public int GradeId { get; set; }
    public string Level { get; set; }
}