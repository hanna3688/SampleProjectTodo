using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyApplication1.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Progress { get; set; }
        [Display(Name ="Due Date")]
        public DateTime? Duedate {get;set;}
        public Category Category { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}