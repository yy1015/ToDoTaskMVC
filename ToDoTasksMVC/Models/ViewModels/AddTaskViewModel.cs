using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoTasksMVC.Models.ViewModels
{
    public class AddTaskViewModel
    {
        [Required]
        [Display( Name = "Task Name" )]
        public string TaskName { get; set; }

        [Required]
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        public bool HasReminder { get; set; }

        public DateTime? ReminderDate { get; set; }
    }
}