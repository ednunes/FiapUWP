using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapTodoApp.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Category Category { get; set; }
    }
}
