using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Frame_Linq
{
    static class Program
    {
        static void Main()
        {
            AnimalFactory.CreateAnimals();

            using (var context = new AnimalContext())
            {
                var cougars = context.Animals.Where(c => c.Name.Contains("CougarWhite")).Count();
                var tigres = context.Animals.Where(c => c.Name.Contains("TigerWhite")).Count();
                var turtles = context.Animals.Where(c => c.Name.Contains("TurtleAlbinos")).Count();             

                MessageBox.Show("Les cougars blancs - Il en reste  " + cougars +
                    "\n" + "Les tigres blancs - Il en reste  " + tigres + 
                    "\n" + "Les tortues albinos - Il en reste  " + turtles, "Tenir compte des espèces protégées",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
