using ToDoList.Models;

namespace ToDoList.Services;

public interface IDataService
{
    Task<List<ToDoEntry>?> LoadToDoEntries();
    Task AddEntry(ToDoEntry entry);
    Task UpdateEntry(ToDoEntry entry);
    Task DeleteEntry(ToDoEntry entry);
}