// IPart.cs
public interface IPart
{
    bool IsBuilt { get; set; } 
}

// IWorker.cs
public interface IWorker
{
    void Work(House house); 
}
