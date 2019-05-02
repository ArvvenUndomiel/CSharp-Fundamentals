using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army___my_solution
{
    class Dragon
    {
        public Dragon(string type, string name, string damage, string health, string armor)
        {
            Type = type;
            Name = name;
            if (damage == "null") damage = "45";
            Damage = int.Parse(damage);
            if (health == "null") health = "250";
            Health = int.Parse(health);
            if (armor == "null") armor = "10";
            Armor = int.Parse(armor);
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            var dragonArmy = new List<Dragon>();

            for (int i = 0; i < n; i++)
            {
                var dragon = ReadDragonStats(Console.ReadLine());

                if (!dragonArmy.Any(d => d.Type.Equals(dragon.Type) && d.Name.Equals(dragon.Name)))
                {
                    dragonArmy.Add(dragon);
                }
                else
                {
                    var existingDragon = dragonArmy.First(d => d.Type.Equals(dragon.Type) && d.Name.Equals(dragon.Name));
                    existingDragon.Health = dragon.Health;
                    existingDragon.Damage = dragon.Damage;
                    existingDragon.Armor = dragon.Armor;
                }
            }

            var DragonsbyType = dragonArmy.GroupBy(d => d.Type).ToList();
            foreach (var type in DragonsbyType)
            {
                var averageDamage = type.Average(x => x.Damage);
                var averageHealth = type.Average(x => x.Health);
                var averageArmor = type.Average(x => x.Armor);
                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in type.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        public static Dragon ReadDragonStats(string input)
        {
            var args = input.Split(' ').ToArray();
            string type = args[0];
            string name = args[1];
            string damage = args[2];
            string health = args[3];
            string armor = args[4];
            Dragon dragon = new Dragon(type, name, damage, health, armor);
            return dragon;
        }
    }
}
