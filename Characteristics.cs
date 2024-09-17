using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heracross
{
    public class Characteristics
    {

        public List<string> at = new List<string>() { "Flamethrower", "Ice Beam", "Fire Punch", "Double Team" };
        public List<string> d = new List<string>() { "Protection from stones" };
        public List<string> spec = new List<string>() { "Flight" };

        public double Hp(double hp)
        {
            return hp;

        }
        public double Attack(double attack)
        {
            return attack;
        }
        public double Defense(double defense)
        {
            return defense;
        }
        public List<string> Spec_At()
        {
            List<string> spec_at = at;
            return spec_at;
        }
        public List<string> SpecDef()
        {
            List<string> spec_def = d;
            return spec_def;
        }

        public List<string> SpecAbil()
        {
            List<string> spec_abil = spec;
            return spec_abil;
        }
        public double Speed(double speed)
        {
            return speed;
        }
    }
}
