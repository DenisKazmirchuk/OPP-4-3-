partial class Department
{
    private string departmentName;
    private int teacherCount;

    public void SetDepartmentName(string name)
    {
        departmentName = name;
    }

    public void SetTeacherCount(int count)
    {
        teacherCount = count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Кафедра: {departmentName}, кількість викладачів: {teacherCount}");
    }
}