namespace OOP_Seminar3;

public class StreamComparator: IComparer<LearningStream>
{
    public int Compare(LearningStream? stream1, LearningStream? stream2)
    {
        if (stream1 is null || stream2 is null)
            throw new ArgumentException("Некорректное значение параметра");
        if (stream1.Count > stream2.Count) return 1;
        if (stream1.Count < stream2.Count) return -1;
        return 0;
    }
}