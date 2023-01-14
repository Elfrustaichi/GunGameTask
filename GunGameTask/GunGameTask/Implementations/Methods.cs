using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Implementations
{
    internal class Methods
    {
        public int Ammo=30;

        public void Shoot()
        {
            if (Ammo>0)
            {
                Ammo -= 1;
                Console.WriteLine("One ammo shooted");
            }
            else
            {
                Console.WriteLine("There is no bullet left pls reload.");
            }
        }

        public void ShootAll()
        {
            if (Ammo > 0)
            {
                Ammo = 0;
                Console.WriteLine("All ammo have shooted.");
                Console.WriteLine("You need to reload");
            }
            else
            {
                Console.WriteLine("There is no bullet left pls reload.");
            }
            
        }
        public void Reload()
        {
            Ammo = 30;
            Console.WriteLine("Reloaded.....");
        }
        public void ShowBullets()
        {
            
            
               Console.WriteLine($"You have left {Ammo} bullets.");
            
            

        }
    }
}
