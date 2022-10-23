using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerFieldManager
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //private static readonly AppData applicationData = new AppData();
        //private static List<UserEntity> userList = applicationData.GetUsers();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            /*
            foreach (UserEntity user in userList)
            {
                Console.WriteLine(user.Id.ToString(), user.FirstName);
                Console.WriteLine();
            }*/

        }
    }
}
