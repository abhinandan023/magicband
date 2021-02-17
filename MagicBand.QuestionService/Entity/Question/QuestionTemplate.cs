using System.Linq;
public class QuestionTemplate
{
    public long Id { get; set; } // Template Id
    public long OwnerId { get; set; } // Owner Id FK from User Table
    public List<ITemplate> Templats { get; set; } // Collection of template of different question type
    public int TotalMark { get { return this.Templates.Sum(template => template.MarksPerQuestionType); } } // Total marks which is being carried by the template 
}