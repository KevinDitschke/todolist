using ToDoList.Models;

namespace ToDoList.Services;

public static class DbInitializer
{
    public static void Initialize(DatabaseContext context)
    {
        if (context.ToDoEntries.Any())
            return;
        var toDoEntries = new List<ToDoEntry>()
        {
            new()
            {
                Title = "Hang your laundry",
                Text = "You need to hang your stupid laundry! God damn it! Hang it already!",
                Done = false,
                ChangedAt = DateTime.UtcNow
            },
            new()
            {
                Title = "Buy groceries",
                Text = "Bring milk, water, bananas and bread",
                Done = false,
                ChangedAt = DateTime.UtcNow
            }
        };
        context.ToDoEntries.AddRange(toDoEntries);
        context.SaveChanges();
    }
}