namespace OOP_Seminar3;

public class StreamService
{
    private readonly List<LearningStream> _streams = new();
    
    public void Sort()
    {
        _streams.Sort(0, _streams.Count, new StreamComparator());
    }

    public void Add(LearningStream stream) => _streams.Add(stream);

    public override string ToString()
    {
        return string.Join("\n", _streams);
    }
}