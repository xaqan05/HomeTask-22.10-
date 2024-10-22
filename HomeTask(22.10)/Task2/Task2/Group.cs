using Task2;

public class Group
{
    private string _groupNo;
    private int _studentLimit;

    public string GroupNo
    {
        get
        {
            return _groupNo;
        }
        set
        {
            if (IsValidGroupName(value))
            {
                _groupNo = value;
            }
            else
            {
                _groupNo = "";
                Console.WriteLine("GroupNo sertleri odemir,2 boyuk herf ve 3 reqem olmalidir.)");
            }
        }
    }

    private Student[] students;
    private int studentCount = 0; 

    public int StudentLimit
    {
        get
        {
            return _studentLimit;
        }
        set
        {
            if (value >= 5 && value <= 18)
            {
                _studentLimit = value;
            }
            else
            {
                Console.WriteLine("Student Limit 5 ve 18 arasi olmalidir.");
            }
        }
    }

    public Group(string groupNo, int studentLimit)
    {
        GroupNo = groupNo;
        StudentLimit = studentLimit;
        students = new Student[studentLimit];
    }

    public void AddStudent(Student student)
    {
        if (studentCount < StudentLimit)
        {
            students[studentCount] = student;
            studentCount++;
            Console.WriteLine("Student elave olundu.");
        }
        else
        {
            Console.WriteLine("Student limiti kecirsiniz.");
        }
    }

    private bool IsValidGroupName(string name)
    {
        if (name.Length != 5) return false;

        for (int i = 0; i < 2; i++)
        {
            if (!char.IsUpper(name[i]))
            {
                return false;
            }
        }

        for (int i = 2; i < 5; i++)
        {
            if (!char.IsDigit(name[i]))
            {
                return false;
            }
        }

        return true;
    }

    public void GetStudent(int id)
    {
        for (int i = 0; i < studentCount; i++)
        {
            if (id == students[i].Id)
            {
                students[i].ShowInfo();
                return;
            }
        }
        Console.WriteLine("Sagird tapilmadi.");
    }

    public void GetAllStudents()
    {
        for (int i = 0; i < studentCount; i++)
        {
            students[i].ShowInfo();
        }
    }
}
