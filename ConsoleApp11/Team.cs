public class Team
{
    private readonly List<IWorker> _workers;

    public Team()
    {
        _workers = new List<IWorker> { new Worker(), new Worker(), new TeamLeader() };
    }

    public void BuildHouse(House house)
    {
        while (!house.IsComplete())
        {
            foreach (var worker in _workers)
            {
                worker.Work(house);
                if (house.IsComplete())
                {
                    Console.WriteLine("The house is complete!");
                    DrawHouse();
                    return;
                }
            }
        }
    }

    private void DrawHouse()
    {
        Console.WriteLine("House drawing:");
        Console.WriteLine("   _______");
        Console.WriteLine("  /       \\");
        Console.WriteLine(" /_________\\");
        Console.WriteLine(" |   _ _  |");
        Console.WriteLine(" |  |  |  |");
        Console.WriteLine(" |__|__|__|");
    }
}
