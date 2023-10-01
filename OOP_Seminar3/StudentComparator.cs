namespace OOP_Seminar3;

public class StudentComparator: IComparer<Student>
{
    public int Compare(Student? student1, Student? student2)
    {
        if(student1 is null || student2 is null) 
            throw new ArgumentException("Некорректное значение параметра");

        if (student1.StudentNumber > student2.StudentNumber) return 1;
        if (student1.StudentNumber < student2.StudentNumber) return -1;
        return 0;
    }
}