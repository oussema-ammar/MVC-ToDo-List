using Microsoft.EntityFrameworkCore;
using MvcToDoList.Data;

namespace MvcToDoList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcToDoListContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcToDoListContext>>()))
            {
                // Look for an To-Do tasks
                if (context.ToDoList.Any())
                {
                    return; // DB has been seeded
                }
                context.ToDoList.AddRange(
                    new ToDoList
                    {
                        TaskName = "Learn Arabic",
                        Description = "Attend online Arabic course",
                        Status = "In Progress",
                        Priority = "Low",
                        Created = DateTime.Parse("2023-05-11"),
                        Deadline = DateTime.Parse("2022-08-07"),
                    },
                    new ToDoList
                    {
                        TaskName = "Look at Linux/Ubuntu",
                        Description = "",
                        Status = "Pending",
                        Priority = "Urgent",
                        Created = DateTime.Now,
                        Deadline = DateTime.Now.AddDays(7),
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
