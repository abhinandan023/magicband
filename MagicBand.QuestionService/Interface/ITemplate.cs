
interface ITemplate
{
    public string QuestionType { get; set; }
    public int NumberOfQuestion { get; set; }
    public int MarksPerQuestion { get; set; }
    public int MarksPerQuestionType { get { return this.MarksPerQuestion * this.NumberOfQuestion; } }
}