﻿using Todo.Api.Enums;

namespace Todo.Api.Models
{
    public class Taskentity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public State State { get; set; }
    }



}
