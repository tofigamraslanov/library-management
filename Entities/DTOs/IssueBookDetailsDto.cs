using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class IssueBookDetailsDto : IDto
    {
        public string StudentName { get; set; }
        public string StudentDepartment { get; set; }
        public int StudentCourse { get; set; }
        public string StudentPhone { get; set; }
        public string BookName { get; set; }
        public DateTime IssueDate { get; set; }
    }
}