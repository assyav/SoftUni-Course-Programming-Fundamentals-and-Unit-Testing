int dogFoodCount = int.Parse(Console.ReadLine());
int catFoodCount = int.Parse(Console.ReadLine());

double totalSumOfFood = dogFoodCount *2.50 + catFoodCount * 4;

Console.WriteLine($"{totalSumOfFood:F2} lv.");