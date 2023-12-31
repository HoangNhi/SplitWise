﻿using System.ComponentModel.DataAnnotations;

namespace BE_WiseWallet.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public required string LeaderId { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public required string Name { get; set; }
        public Image? Image { get; set; }
        public string? LinkInvite { get; set; }
        
        // This property use for join team by sign Code
        public string? CodeInvite { get; set; }
        public double TotalPaid { get; set; } = 0;
        public Boolean isCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }  
}
