string architectName = Console.ReadLine();
int numberOfProjects = int.Parse(Console.ReadLine());

int hoursCount = numberOfProjects * 3;

Console.WriteLine($"The architect {architectName} will need {hoursCount} hours to complete {numberOfProjects} project/s.");
