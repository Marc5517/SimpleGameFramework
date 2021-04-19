using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using SimpleGameFramework;
using SimpleGameFramework.Objects;
using SimpleGameFramework.Objects.Base;

namespace Framework
{
    public class GameWorker
    {
        private int _maxX;
        private int _maxY;

        public GameWorker(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public void Start()
        {
            World w = new World(_maxX, _maxY);
            Console.WriteLine("The world's range is: " + w);

            Console.ReadKey();

            Creature c = new Creature("Troll", new PositiveInt(750), 35, 20, GameTrace.GT, new Position(2, 5));
            Creature c2 = new Creature("Wolfman", new PositiveInt(49), 24, 20, GameTrace.GT, new Position(3, 4));

            AttackItem a = new AttackItem("Doom Sword", 34, 3, true, false, new Position(3, 6), GameTrace.GT);
            AttackItem a2 = new AttackItem("Almighty Sword", 20, 5, true, true, new Position(2, 7), GameTrace.GT);
            DefenceItem d = new DefenceItem("Protection Shield", 20, true, false, new Position(5, 8), GameTrace.GT);
            DefenceItem d2 = new DefenceItem("Almighty Shield", 30, false, false, new Position(5, 8), GameTrace.GT);

            Console.WriteLine("---- The weapons ----");
            Console.WriteLine(a);
            Console.WriteLine(a2);
            Console.WriteLine(d);
            Console.WriteLine(d2);

            Console.ReadKey();

            Console.WriteLine("---------");
            Console.WriteLine(c);
            Console.WriteLine("Vs.");
            Console.WriteLine(c2);

            Console.ReadKey();

            Console.WriteLine("---- " + c.Name + " loots " + a.Name + " and " + d.Name + " ----");
            c.LootAttackItem(a);
            c.LootDefenseItem(d);
            Console.WriteLine(c);

            Console.ReadKey();

            Console.WriteLine("---- " + c2.Name + " tries to loot " + d2.Name + " ----");
            c2.LootDefenseItem(d2);
            Console.WriteLine(c2);

            Console.ReadKey();

            Console.WriteLine("---- " + c.Name + " tries to loot " + a2.Name + " ----");
            c.LootAttackItem(a2);
            Console.WriteLine(c);

            Console.ReadKey();

            Console.WriteLine("---- " + c.Name + " attacks " + c2.Name + " ----");
            c.Hit();
            c2.ReceiveHit(c.Hit());
            Console.WriteLine(c);
            Console.WriteLine(c2);

            GameTrace.GT.Close();
        }
    }
}
