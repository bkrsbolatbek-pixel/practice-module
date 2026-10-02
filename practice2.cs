class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double FoodAmount { get; set; }
    public string FoodType { get; set; }

    public virtual void CalculateFood()
    {
        FoodType = "Тамақ";
    }
}

class Carnivore : Animal
{
    public override void CalculateFood() => FoodType = "Ет";
}

class Omnivore : Animal
{
    public override void CalculateFood() => FoodType = "Аралас";
}

class Herbivore : Animal
{
    public override void CalculateFood() => FoodType = "Шөп";
}

class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Carnivore { Id = 1, Name = "Арыстан", FoodAmount = 15 },
            new Herbivore { Id = 2, Name = "Қоян", FoodAmount = 1 },
            new Omnivore { Id = 3, Name = "Aю", FoodAmount = 20 },
            new Carnivore { Id = 4, Name = "Бөрі", FoodAmount = 7 },
            new Herbivore { Id = 5, Name = "Піл", FoodAmount = 50 },
            new Omnivore { Id = 6, Name = "Маймыл", FoodAmount = 4 }
        };

        for (int i = 0; i < animals.Length; i++) animals[i].CalculateFood();

        for (int i = 0; i < animals.Length - 1; i++)
        {
            for (int j = i + 1; j < animals.Length; j++)
            {
                if (animals[i].FoodAmount < animals[j].FoodAmount)
                {
                    Animal temp = animals[i];
                    animals[i] = animals[j];
                    animals[j] = temp;
                }
            }
        }

        for (int i = 0; i < animals.Length; i++)
        {
            System.Console.WriteLine(animals[i].Id + " " + animals[i].Name + " " + animals[i].FoodType + " " + animals[i].FoodAmount);
        }

        for (int i = 0; i < 5 && i < animals.Length; i++)
        {
            System.Console.WriteLine(animals[i].Name);
        }

        for (int i = animals.Length - 3; i < animals.Length; i++)
        {
            if (i >= 0) System.Console.WriteLine(animals[i].Id);
        }

        string path = "animals.txt";
        System.IO.File.WriteAllText(path, "1;Арыстан;15;Ет");

        try
        {
            string[] lines = System.IO.File.ReadAllLines(path);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}