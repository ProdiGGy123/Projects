using System;
using Player_Character;

namespace What_Am_I
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUnit Robin = new MyUnit(1);
            Robin.Weapon = "Levin Sword";
            Robin.MagicAttack = 9;

            MyUnit Chrom = new MyUnit(2);
            Chrom.Weapon = "Exalted Falchion";
            Chrom.WeaponAttack = 15;

            MyUnit Lucina = new MyUnit(3);
            Lucina.Weapon = "Parallel Falchion";
            Lucina.WeaponAttack = 11;

            MyUnit Morgan = new MyUnit(1);
            Morgan.Weapon = "Thoron";
            Morgan.MagicAttack = 12;


        }
    }
}
