using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.PlayersAndMonsters
{

    public class Hero
    {
        public string UserName { get; set; }
        public int Level { get; set; }

        public Hero(string userName, int level)
        {
            UserName = userName;
            Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.UserName} Level: {this.Level}";
        }
    }

    public class Elf : Hero
    {
        public Elf(string username, int level) : base(username, level)
        {

        }
    }

    public class MuseElf : Elf
    {
        public MuseElf(string username, int level) : base(username, level)
        {

        }
    }

    public class Wizard : Hero
    {
        public Wizard(string username, int level) : base(username, level)
        {

        }
    }
    public class DarkWizard : Wizard
    {
        public DarkWizard(string username, int level) : base(username, level)
        {

        }
    }

    public class SoulMaster : DarkWizard
    {
        public SoulMaster(string username, int level) : base(username, level)
        {
        }
    }

    public class Knight : Hero
    {
        public Knight(string username, int level) : base(username, level)
        {
        }
    }

    public class DarkKnight : Knight
    {
        public DarkKnight(string username, int level) : base(username, level)
        {
        }
    }

    public class BladeKnight : DarkKnight
    {
        public BladeKnight(string username, int level) : base(username, level)
        {
        }
    }

    public class Program
    {
        static void Main()
        {
            
        }
    }
}