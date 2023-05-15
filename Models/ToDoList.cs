using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcToDoList.Models
{
    public class ToDoList
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string TaskName { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }
        public string Status { get; set; }

        [NotMapped]
        public List<SelectListItem> StatusList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Pending", Text = "Pendinng" },
            new SelectListItem { Value = "In progress", Text = "In progress" },
            new SelectListItem { Value = "Complete", Text = "Complete" },
        };

        public string Priority { get; set; }

        [NotMapped]
        public List<SelectListItem> PriorityList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Urgent", Text = "Urgent" },
            new SelectListItem { Value = "High", Text = "High" },
            new SelectListItem { Value = "Medium", Text = "Medium" },
            new SelectListItem { Value = "Low", Text = "Low" },
        };

        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Deadline")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; } = DateTime.Now.AddDays(7);
    }
}