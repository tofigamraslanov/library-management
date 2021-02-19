using Core.Entities;

namespace Entities.Concrete
{
    public class Librarian : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}