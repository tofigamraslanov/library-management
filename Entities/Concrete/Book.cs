using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}