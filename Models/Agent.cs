using System;

namespace dotnetapi.Models
{
    public class Agent
    {
        public int AgentId { get; set; }
        public int UserId { get; set; }
        public int ManagerId { get; set; }
        public bool IsManager { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // RELATIONSHIPS
        public User User { get; set; }
    }
}