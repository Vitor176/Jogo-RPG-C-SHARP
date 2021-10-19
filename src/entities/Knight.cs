using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO_DIO.src.entities
{
    class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base (Name,Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack()
        {
            return this.Name + "Atacou";
        }
    }
}
