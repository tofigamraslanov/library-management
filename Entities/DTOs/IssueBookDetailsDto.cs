using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class IssueBookDetailsDto : IDto
    {
        public int IssueBookId { get; set; }
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public DateTime IssueDate { get; set; }
    }
}