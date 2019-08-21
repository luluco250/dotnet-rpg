using System;

class Program {
    static void Main(string[] args) {
        var actor = new Actor{
            name = "Lucas",
            health = 125,
            stamina = 125,
            mana = 0
        };

        Console.WriteLine(actor);
    }
}