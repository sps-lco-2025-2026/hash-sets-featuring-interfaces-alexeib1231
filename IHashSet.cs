namespace HashSet.Lib;

    public interface IHashSet<T> 
        where T : SPSStudent, IEquatable<T>
    {
        T Add(T value);
        bool IsPresent(T value);
        void Rebalance();
    }

    public interface SPSStudent : IEquatable<SPSStudent>
    {
        string Name { get; }
        string Year { get; }
        string Tutor { get; }
    }


public class SPSStudent
{
    string _name;
    int _year;
    string _initials;

    public override string ToString()
    {
        return (_name, _year, _initials);
    }
    public override int GetHashCode()
    {
        
    }
} 

public class IHashSet<T>