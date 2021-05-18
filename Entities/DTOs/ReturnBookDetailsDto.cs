using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class ReturnBookDetailsDto : IDto
    {
        public int ReturnBookId { get; set; }
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Fine { get; set; }
    }
}