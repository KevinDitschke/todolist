namespace ToDoList.Models;

public class ToDoEntry
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public bool Done { get; set; }
    public DateTime ChangedAt { get; set; }
}