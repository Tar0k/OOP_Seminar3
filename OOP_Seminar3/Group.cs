using System.Collections;

namespace OOP_Seminar3;

public class Group: IEnumerable<Student>, IEnumerator<Student>
{
    private readonly List<Student> _students;
    private int _index;
    private Student _current;

    public Group(string name, IEnumerable<Student> students)
    {
        _students = new List<Student>(students);
        _students.Reverse();
        _index = _students.Count;
        _current = _students.Last();
        Name = name;
    }

    public string Name { get; }
    
    
    public bool MoveNext()
    {
        _index--;
        if (_index < 0) return false;
        _current = _students[_index];
        return true;
    }

    public void Reset() => _index = _students.Count - 1;
    public object Current => _current;

    Student IEnumerator<Student>.Current => _current;


    public void Remove()
    {
        _students.Remove(_current);
    }


    public IEnumerator<Student> GetEnumerator()
    {
        return this;
    }

    public override string ToString()
    {
        return string.Join(" | ", _students);
    }

    public void Dispose() {}

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    public void Sort()
    {
        _students.Sort(0, _students.Count, new StudentComparator());
    }
}