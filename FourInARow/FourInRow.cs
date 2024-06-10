using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace FourInARow
{
    class FourInRow
    {
           static void Main(string[] args)
        {
            //Creating the different objects
            Console.WriteLine("FourInRow test");
            Player player1 = new Player();
            player1.name = "Pepe";
            Console.WriteLine(player1.score);

            //Starting the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}
