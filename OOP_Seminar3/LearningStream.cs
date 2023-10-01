using System.Collections;

namespace OOP_Seminar3;

public class LearningStream(string name, List<Group> groups) : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        return groups.GetEnumerator();
    }

    public int Count => groups.Count;
    private string Name { get; } = name;

    public override string ToString()
    {
        return $"{Name}:{Count}";
    }

    public void GenerateRandomGroup(int times = 1)
    {
        var random = new Random();

        for (var i = 0; i < times; i++)
        {
            var newStudents = new List<Student>();
            for (var j = 0; j < 30; j++)
            {
                var student = new Student(fullName: Faker.Name.FullName(),
                    studentNumber: random.Next(1, 1000),
                    birthDate: DateOnly.FromDateTime(Faker.Identification.DateOfBirth()));
                newStudents.Add(student);
            }

            groups.Add(new Group(name: $"{Name}_{random.Next(1, 200)}",
                new List<Student>(newStudents)
            ));
        }
    }
}