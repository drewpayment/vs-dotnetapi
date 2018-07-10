using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapi.Models
{
    public class UserDetail
    {
        public int UserDetailId { get; set; }
        public int UserId { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Ssn { get; set; }
        public int Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int BankRouting { get; set; }
        public int BankAccount { get; set; }
        public int SaleOneId { get; set; }
        public int SaleOneCampaignId { get; set; }
        public int SaleTwoId { get; set; }
        public int SaleTwoCampaignId { get; set; }
        public int SaleThreeId { get; set; }
        public int SaleThreeCampaignId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        // RELATIONSHIPS
        public virtual User User { get; set; }

    }
}