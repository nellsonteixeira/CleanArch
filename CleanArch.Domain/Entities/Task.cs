using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanArch.Domain.Entities
{
    /// <summary>
    /// Represent a Event
    /// </summary>
    public class Task
    {
        public int Id { get; protected set; }
        public string Description { get; protected set; }
        public DateTime ScheduleDate { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdateAt { get; protected set; }

        public Task(string description, DateTime scheduleDate, DateTime createdAt, int id = 0)
        {
            Id = id;
            Description = description;
            ScheduleDate = scheduleDate;
            CreatedAt = createdAt;
        }
    }
}
