
public interface IOption {
    int Id { get; set; }
    string OptionText { get; set; }
    List<string> ImageUrls { get; set; }
    bool IsCorrect  { get; set; }
}