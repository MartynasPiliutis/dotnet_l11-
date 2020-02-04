using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagerLibrary;

namespace UserManager
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            Console.WriteLine("Pasirinkite ataskaitos tipa:");
            Console.WriteLine(" * Visi vartotojai [1]");
            Console.WriteLine(" * Vartotojai pagal teises [2]");
            Console.Write("Jusu pasirinkimas: ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                List<User> UsersList = userRepository.GetUsersList();
                ReportGenerator reportGenerator = new ReportGenerator(UsersList);

                List<ReportItem> reportList = reportGenerator.GenerateAllUsersList();

                Console.WriteLine("Visas Vartotojus sarasas:");
                foreach (var item in reportList)
                {
                    Console.WriteLine($"{item.UserId} {item.UserName} {item.RightCode}");
                }
                Console.ReadLine();
            }
            else if (pasirinkimas == 2)
            {
                Console.WriteLine("Pasirinkite, kokias teises turi jusu vartotojai:");
                Console.WriteLine("0 - Read Only; 1 - Approve/Reject; 2 - Full Access");
                int teisiuPasirinkimas = Convert.ToInt32(Console.ReadLine());
                
                List<User> UsersList = userRepository.GetUsersList();
                ReportGenerator reportGenerator = new ReportGenerator(UsersList);

                List<ReportItem> reportList = reportGenerator.GenerateUsersListByRightCode(teisiuPasirinkimas);

                foreach (var item in reportList)
                {
                    Console.WriteLine($"{item.UserId} {item.UserName} {item.RightCode}");
                }
                Console.ReadLine();
            }
            /*            else
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Spauskite bet kuri mygtuka kad baigti darba...");
                            Console.ReadKey();
                        }*/

            Console.Clear();
            Console.WriteLine("Iveskite vartotojo ID:");
            int vartotojoId = Convert.ToInt32(Console.ReadLine());

            User ieskomasVartotojas = userRepository.GetUserByID(vartotojoId);
            Console.WriteLine("Jusu ieskotas vartotojas:");
            Console.WriteLine($"{ieskomasVartotojas.UserID} {ieskomasVartotojas.UserName} {ieskomasVartotojas.GetUserRightsID()}");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Iveskite naujo vartotojo ID:");
            int naujoVartotojoId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite naujo vartotojo varda:");
            string naujoVartotojoVardas = Console.ReadLine();

            Console.WriteLine("Iveskite naujo vartotojo teises:");
            int naujoVartotojoTeises = Convert.ToInt32(Console.ReadLine());
            
            userRepository.AddNewUser(naujoVartotojoId, naujoVartotojoVardas, naujoVartotojoTeises);
            User najasVartotojas = userRepository.GetUserByID(naujoVartotojoId);
            Console.WriteLine("Jusu sukurtas vartotojas:");
            Console.WriteLine($"{najasVartotojas.UserID} {najasVartotojas.UserName} {najasVartotojas.GetUserRightsID()}");
            Console.ReadLine();

            Console.Clear();
            List<User> UsersListNew = userRepository.GetUsersList();
            ReportGenerator reportGeneratorNew = new ReportGenerator(UsersListNew);
            List<ReportItem> reportListNew = reportGeneratorNew.GenerateAllUsersList();
            Console.WriteLine("Visas Vartotojus sarasas:");
            foreach (var item in reportListNew)
            {
                Console.WriteLine($"{item.UserId} {item.UserName} {item.RightCode}");
            }
            Console.WriteLine();
            Console.WriteLine("Iveskite vartotojo ID kuri norite pasalinti:");
            int trinamoVartotojoId = Convert.ToInt32(Console.ReadLine());
            userRepository.DeleteUserByID(trinamoVartotojoId);
            List<ReportItem> reportListNew2 = reportGeneratorNew.GenerateAllUsersList();
            Console.WriteLine("Visas Vartotojus sarasas:");
            foreach (var item in reportListNew2)
            {
                Console.WriteLine($"{item.UserId} {item.UserName} {item.RightCode}");
            }

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Iveskite vartotojo ID:");
            int vartotojoIdRedaguoti = Convert.ToInt32(Console.ReadLine());

            User ieskomasVartotojasRedaguoti = userRepository.GetUserByID(vartotojoIdRedaguoti);
            Console.WriteLine("Jusu ieskotas vartotojas:");
            Console.WriteLine($"{ieskomasVartotojasRedaguoti.UserID} {ieskomasVartotojasRedaguoti.UserName} {ieskomasVartotojasRedaguoti.GetUserRightsID()}");

            Console.WriteLine("Pasirinkite, kokias naujas teises suteikti siam vartotojui:");
            Console.WriteLine("0 - Read Only; 1 - Approve/Reject; 2 - Full Access");
            int naujosTeises = Convert.ToInt32(Console.ReadLine());
            ieskomasVartotojasRedaguoti.ChangeUserRights(new Right(naujosTeises));
            Console.WriteLine("Vartotojo naujos teises:");
            Console.WriteLine($"{ieskomasVartotojasRedaguoti.UserID} {ieskomasVartotojasRedaguoti.UserName} {ieskomasVartotojasRedaguoti.GetUserRightsID()}");
            Console.ReadLine();

        }
    }
}
