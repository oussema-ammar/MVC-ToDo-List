using Microsoft.EntityFrameworkCore;
using MvcToDoList.Models;

namespace MvcToDoList.Data
{
    public class MvcToDoListContext : DbContext
    {
        public MvcToDoListContext (DbContextOptions<MvcToDoListContext> options): base(options)
        {
        }
        public DbSet<ToDoList> ToDoList { get; set; }
    }
}
