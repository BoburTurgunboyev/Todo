namespace Todo.Blazor.Models
{
    public class Taskentity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string State { get; set; }
    }
}
