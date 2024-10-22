namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("BP215",5);

            Student student = new Student("Xaqan Ismayilov",95);
           



            group.AddStudent(student);

            group.GetStudent(1);

            group.GetAllStudents();

        }
    }
}
