using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}
