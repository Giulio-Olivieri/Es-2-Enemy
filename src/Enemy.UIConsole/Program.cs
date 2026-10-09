using System.Numerics;
using Player.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hi, this is the Enemy project.");
            Console.WriteLine("");
            Console.WriteLine("Give me a name for your enemy:");
            string name = Console.ReadLine();
            int MaxHealth = 100;
            Enemy enemy1 = new Enemy(name, 1, 0, MaxHealth, MaxHealth, true, 0);
            Console.WriteLine($"Enemy: {enemy1.Name} ");
            Console.WriteLine($"Level: {enemy1.Level} ");
            Console.WriteLine($"Experience: {enemy1.Experience} ");
            Console.WriteLine($"Health: {enemy1.Health} ");
            Console.WriteLine($"MaxHealth: {enemy1.MaxHealth} ");
            Console.WriteLine($"IsAlive: {enemy1.IsAlive} ");
            Console.WriteLine($"Gold: {enemy1.Gold} ");
            Console.WriteLine("");
            Console.WriteLine("Now, let's simulate some actions on the enemy.");
            Console.WriteLine("");
            enemy1.Addexperience(470);
            Console.WriteLine("Added 470 experience points.");
            Console.WriteLine("Current experience: " + enemy1.Experience);
            Console.WriteLine("Current level: " + enemy1.Level);
            Console.WriteLine("Resetting experience...");
            enemy1.ResetExperience();
            Console.WriteLine("");
            Console.WriteLine("Taking 30 damage...");
            enemy1.TakeDamage(30);
            Console.WriteLine("Current health: " + enemy1.Health);
            Console.WriteLine("");
            Console.WriteLine("Healing 20 health...");
            enemy1.Heal(20);
            Console.WriteLine("Current health: " + enemy1.Health);
            Console.WriteLine("");
            Console.WriteLine("Adding 50 gold...");
            enemy1.AddGold(50);
            Console.WriteLine("Current gold: " + enemy1.Gold);
            Console.WriteLine("");
            Console.WriteLine("Resetting health...");
            enemy1.resetHealth();
            Console.WriteLine("Current health: " + enemy1.Health);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");


        }
    }
}


