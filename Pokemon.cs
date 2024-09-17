using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heracross
{
    public class Pokemon
    {

        // Хранение характеристик покемона
        Characteristics characteristics = new Characteristics();

        public void Info()
        {
            Console.WriteLine("Heracross"); // Имя покемона
            Console.WriteLine("HP: " + characteristics.Hp(100)); // Здоровье
            Console.WriteLine("Atack: " + characteristics.Attack(5)); // Атака
            Console.WriteLine("Defense: " + characteristics.Defense(16 - 5 / 2)); // Защита
            Console.WriteLine("Special attack: " + string.Join(", ", characteristics.Spec_At())); // Специальная атака
            Console.WriteLine("Special defense: " + string.Join(", ", characteristics.SpecDef())); // Специальная защита
            Console.WriteLine("Speed: " + characteristics.Speed(5)); // Скорость
        }
    }
}
