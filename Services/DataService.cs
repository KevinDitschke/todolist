using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Services;

public class DataService
{
    private readonly DatabaseContext _context;

    public DataService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<ToDoEntry>?> LoadToDoEntries()
    {
        var entries = await _context.ToDoEntries.ToListAsync();
        return entries;
    }

    public async Task AddEntry(ToDoEntry entry)
    {
        entry.ChangedAt = DateTime.UtcNow;
        _context.ToDoEntries.Add(entry);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEntry(ToDoEntry entry)
    {
        entry.ChangedAt = DateTime.UtcNow;
        _context.ToDoEntries.Update(entry);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEntry(ToDoEntry entry)
    {
        _context.ToDoEntries.Remove(entry);
        await _context.SaveChangesAsync();
    }
}