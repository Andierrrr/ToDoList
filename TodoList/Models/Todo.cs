using System;
using Microsoft.VisualBasic;

namespace ToDoList.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
    }
}

