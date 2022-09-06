namespace DATN2022.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress Address { get; set; }
    }
}
