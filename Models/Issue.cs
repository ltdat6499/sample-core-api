using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_project.Models
{
    public class Issue
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public Priority priority { get; set; }
        public Type type { get; set; }
        public Status status { get; set; }
        public DateTime createdAt
        { get; set; }
        public DateTime updatedAt { get; set; }
    }
    public enum Priority
    {
        Low, Medium, High
    }
    public enum Type
    {
        Feature, Bug, Documentation
    }
    public enum Status
    {
        New, Processing, Completed, Failed
    }
}