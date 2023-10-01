

namespace OOP_Seminar3;

public class LearningGroupService(List<Group> groups)
{
    public void RemoveByName(string name)
    {
        foreach (var group in groups)
        {
            foreach (var student in group)
            {
                if (student.FullName == name) group.Remove();
            }
        }
    }
}