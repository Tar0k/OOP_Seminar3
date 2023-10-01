namespace OOP_Seminar3;

public class Student(string fullName, int studentNumber, DateOnly birthDate) : IComparable
{
    public string FullName { get; } = fullName;
    public int StudentNumber { get; set; } = studentNumber;
    public DateOnly BirthDate { get; init; } = birthDate;

    public override string ToString()
    {
        return FullName + ":" + StudentNumber;
    }
    
    public int CompareTo(object? o)
    {
        if(o is Student student) return string.Compare(FullName, student.FullName, StringComparison.Ordinal);
        throw new ArgumentException("Некорректное значение параметра");
    }
}