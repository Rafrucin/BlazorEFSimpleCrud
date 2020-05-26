using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEFSimpleCrud
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Task name is required")]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        [MaxLength (100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [MaxLength (50)]
        public string Status { get; set; }

        [Required(ErrorMessage = "Due Date is required")]
        public DateTime DueDate { get; set; }
    }
}

