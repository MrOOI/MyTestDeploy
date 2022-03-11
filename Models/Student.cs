namespace MyTestDeploy.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }

        public Student(string _ism, int _course)
        {
            this.Course = _course;
            this.Name = _ism;
        }

        public Student()
        {

        }
    }
}
