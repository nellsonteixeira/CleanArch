namespace CleanArch.Api.Models
{
    public class TaskViewModel
    {
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class TaskUpdateModel : TaskViewModel
    {
        public int Id { get; set; }
    }
}
