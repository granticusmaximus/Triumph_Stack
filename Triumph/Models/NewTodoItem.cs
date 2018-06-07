using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class NewTodoItem
    {
        [Required]
        public string Title { get; set; }
    }
}
