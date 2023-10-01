using System.Collections;

namespace OOP_Seminar3;

public class Stream(string name, List<LearningGroupService> groups) : IEnumerable
{
    private readonly List<LearningGroupService> Groups = groups;

    public IEnumerator GetEnumerator()
    {
        return Groups.GetEnumerator();
    }

    public int Count => Groups.Count;
    public string Name { get; } = name;
}