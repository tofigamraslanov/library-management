using Core.Entities;

namespace Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Course { get; set; }
        public string Phone { get; set; }
    }
}