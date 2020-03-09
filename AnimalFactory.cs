using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Frame_Linq
{
    public class AnimalFactory
    {
        public static void CreateAnimals()
        {
            using (var context = new AnimalContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Random random = new Random();

                var cougarWhite = new Species { Name = "CougarWhite" };
                var tigerWhite = new Species { Name = "TigerWhite" };
                var turtleAlbinos = new Species { Name = "TurtleAlbinos" };

                context.Add(cougarWhite);
                context.Add(tigerWhite);
                context.Add(turtleAlbinos);

                // Create CougarWhite

                for (int i = 1; i <= 3; i++)
                {
                    int value = random.Next(1, 50);
                    var animal = new Animal
                    { Name = $"CougarWhite{i}", Species = cougarWhite, BirthDay = DateTime.Today - TimeSpan.FromDays(100 * value) };
                    context.Add(animal);
                }

                // Create TigerWhite

                for (int i = 1; i <= 100; i++)
                {
                    int value = random.Next(1, 70);
                    var animal = new Animal
                    { Name = $"TigerWhite{i}", Species = tigerWhite, BirthDay = DateTime.Today - TimeSpan.FromDays(100 * value) };
                    context.Add(animal);
                }

                // TurtleAlbinos

                for (int i = 1; i <= 15; i++)
                {
                    int value = random.Next(1, 300);
                    var animal = new Animal
                    { Name = $"TurtleAlbinos{i}", Species = turtleAlbinos, BirthDay = DateTime.Today - TimeSpan.FromDays(100 * value) };
                    context.Add(animal);
                }

                context.SaveChanges();
            }
        }
                        
    }
}
