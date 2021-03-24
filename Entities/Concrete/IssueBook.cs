using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class IssueBook : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
