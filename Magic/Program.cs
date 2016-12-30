using Magic.Data.Models;
using Magic.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            //{

            //    unitOfWork.Users.Add(new User()
            //    {
            //        Name = "Cristian Gerardo",
            //        LastName = "Jaramillo",
            //        SecondLastName = "Cruz"
            //    }
            //    );

            //    unitOfWork.Users.AddRange(new List<User>() {
            //            new User() {
            //                Name = "Cristian Gerardo",
            //                LastName = "Jaramillo",
            //                SecondLastName = "Cruz"
            //            },
            //            new User() {
            //                Name = "Edgar Daniel",
            //                LastName = "Jaramillo",
            //                SecondLastName = "Cruz"
            //            },
            //            new User() {
            //                Name = "Jenifer",
            //                LastName = "Jaramillo",
            //                SecondLastName = "Cruz"
            //            },
            //    });

            //    unitOfWork.Complete();
                
            //    var users = unitOfWork.Users.GetAll();

            //    foreach (User u in users)
            //    {
            //        Console.WriteLine("{0} {1} {2}", u.Name, u.LastName, u.SecondLastName);
            //    }

            //    Console.ReadLine();
                
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

    }
}
