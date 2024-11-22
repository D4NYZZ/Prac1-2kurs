using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Student : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
    }

    public interface IDomainObject
    {
        int ID { get; set; }
    }
}
