using System;
using TheTyrants.Models.Teachers;
using TheTyrants.Models.Students;
using TheTyrants.Models.Paterns;
using TheTyrants;
using System.Collections.Generic;
using TheTyrants.Models;

namespace TheTyrants.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";

            Console.WriteLine("Bienvenue dans le monde des 2ème année d'ingé!");
            Console.WriteLine();

            Arthur arthur = new Arthur { Name = "Pfauwadel", Id = "Art", Life = 5, Age = 22, FirstName = "Arthur", Hostility = 1 };
            Mathilde mathilde = new Mathilde { Name = "Mistler", Id = "Mat", Life = 5, Age = 22, FirstName = "Matilde", Hostility = 1 };
            Jerome jerome = new Jerome { Name = "Sustranck", Id = "Jer", Life = 5, Age = 22, FirstName = "Jerome", Hostility = 1 };
            Loic loic = new Loic { Name = "Ebele", Id = "Loi", Life = 5, Age = 22, FirstName = "Loic", Hostility = 1 };

            Eisenmann eisenmann = new Eisenmann { Name = "Eisenmann", FirstName = "Claude", Discipline = "Methodologie", Life = 5, Patience = 6, manliness = 5 };
            Maurice maurice = new Maurice { Name = "Maurice", FirstName = "Emmanuel", Discipline = "Web", Life = 5, Patience = 6, manliness = 4 };
            PapyCompta papyCompta = new PapyCompta { Name = "Kraess", FirstName = "Henry", Discipline = "Compta", Life = 5, Patience = 6, manliness = 3 };
            Thery thery = new Thery { Name = "Thery", FirstName = "Sylvain", Discipline = "C", Life = 5, Patience = 6, manliness = 2 };

            List<Teacher> listTeachers = new List<Teacher>();
            listTeachers.Add(eisenmann);
            listTeachers.Add(maurice);
            listTeachers.Add(papyCompta);
            listTeachers.Add(thery);

            List<Student> listStudents = new List<Student>();
            listStudents.Add(arthur);
            listStudents.Add(mathilde);
            listStudents.Add(jerome);
            listStudents.Add(loic);


            /*  foreach (Student std in listStudents)
              {               
                 std.SetMemento(std.Id,std.Life);
              }
              foreach (Teacher tch in listTeachers)
              {
                  tch.SetMemento(tch.Id, tch.Life);
              }*/



            //bool loop = true;

            while (mathilde.Life >= 0 && arthur.Life >= 0 && jerome.Life >= 0 && loic.Life >= 0 && eisenmann.Life >= 0 && maurice.Life >= 0 && papyCompta.Life >= 0 && thery.Life >= 0)
            {

                Console.WriteLine("Le cours commence...");
                Console.WriteLine(eisenmann.Teach());
                Console.WriteLine(arthur.ToBeLate());
                Console.WriteLine("Quelle est la réaction de" + eisenmann.Name + "?");
                Console.WriteLine("1: il laisse courrir  ou 2: il s'enerve");
                res = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (res.Equals("1"))
                {
                    eisenmann.PatienceReedeem();
                    Console.WriteLine("Il reprend son cours.");
                }
                else
                {
                    Console.WriteLine(eisenmann.LoosePatience());
                    Console.WriteLine(eisenmann.Threat());
                    Console.WriteLine(eisenmann.LooseLife(2));
                }
                Console.ResetColor();
                Console.WriteLine("Le cours se finit...");
                Console.ReadKey();

                Console.WriteLine("Le cours de " + maurice.Discipline + " commence...");
                Console.WriteLine(maurice.Teach());
                Console.WriteLine(mathilde.Nitpick());
                Console.WriteLine(maurice.Name + " a 2 possibilités: 1: il se venge ou 2: il sort mathilde de classe.");
                Console.WriteLine("Lancez le dé ^^");
                Console.ReadKey();

                int dice = Dice.ThrowDice(1, 3);
                Console.ForegroundColor = ConsoleColor.Red;
                if (dice == 1)
                {
                    Console.WriteLine(maurice.BeBipoloar());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(mathilde.LooseLife(3));
                }
                Console.ResetColor();
                Console.WriteLine("Le cours se finit...");
                Console.ReadKey();


                Console.WriteLine("\r\n Le lendemain, après une bonne nuit de sommeil:");
                Console.WriteLine(thery.Teach());
                Console.WriteLine(loic.Sleep());
                Console.WriteLine("2 possibilités, si vous échouez, Loic perd de la vie: \r\n Pour déterminer la suite, répondez à l'énigme suivante:");
                bool riddleResolution = false;

                Console.WriteLine("Les chats peuvent boire de l'eau salée, vrai(1) ou faux(2)");
                res = Console.ReadLine();
                if (res == "1")
                { riddleResolution = true; }
                Console.WriteLine("La réponse est VRAI. Les reins des chats parviennent à filtrer le sel marin. \r\n Cette particularité leur permet de s’hydrater avec de l’eau de mer.");
                Console.ForegroundColor = ConsoleColor.Red;
                if (!riddleResolution)
                {
                    Console.WriteLine(thery.SpeackAlone());
                    Console.WriteLine(loic.LooseLife(2));
                }
                else
                {
                    Console.WriteLine(thery.Cry());
                }
                Console.ResetColor();

                Console.ReadKey();
                Console.WriteLine("Le cours de " + papyCompta.Discipline + " commence.");
                Console.WriteLine(jerome.Nitpick());
                Console.WriteLine("Blague: Un jour Dieu dit à Casto de ramer.");
                Console.ReadKey();
                Console.WriteLine("Et depuis, castorama...");
                Console.ReadKey();
                Console.WriteLine("Avez vous ri? \r\n si oui, tapez 1, si non tapez 2");
                res = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (res == "1")
                {
                    Console.WriteLine(papyCompta.BecomeAngry());
                }
                else
                {
                    Console.WriteLine(papyCompta.HitTheTableWithARuler());
                    Console.WriteLine(jerome.LooseLife(1));
                }
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("\r\n Le lendemain, après une bonne nuit de sommeil:");
                Console.WriteLine("Le cours commence...");
                Console.WriteLine(eisenmann.Teach());
                Console.WriteLine((mathilde.Chat()));
                Console.WriteLine("2 pssibilités: " + eisenmann.Name + " se moque d'elle (1) ou il la menace (2)");
                res = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (res == "1")
                {
                    Console.WriteLine(eisenmann.LaughAtStudents());
                    Console.WriteLine(mathilde.LooseLife(1));
                }
                else
                {
                    Console.WriteLine(eisenmann.Threat());
                }
                Console.ResetColor();
                Console.ReadKey();

                Console.WriteLine("Le cours se finit...");
                Console.ReadKey();
                Console.WriteLine("Le cours de " + maurice.Discipline + " commence...");
                Console.WriteLine(maurice.Teach());
                Console.WriteLine(arthur.Sleep());
                Console.WriteLine("Blague: Un chien et un homme son sur un bateau. \r\n Le chien pète, l'homme tombe à l'eau et se noie.\r\n  Quelle est la race du chien ?)");
                Console.ReadKey();
                Console.WriteLine("Un pékinois. (un pet qui noie)");
                Console.ReadKey();
                Console.WriteLine("Avez vous ri? \r\n si oui, tapez 1, si non tapez 2");
                res = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (res == "1")
                {
                    Console.WriteLine(arthur.ThrowSomething());
                    Console.WriteLine(maurice.LooseLife(3));
                }
                else
                {
                    Console.WriteLine(maurice.BecomeAngry());
                    Console.WriteLine(arthur.LooseLife(1));
                }
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("\r\n Le lendemain, après une bonne nuit de sommeil:");
                Console.WriteLine(thery.Teach());
                Console.WriteLine(jerome.Play());
                Console.WriteLine("2 possibilités, si vous échouez, jerome perd de la vie: \r\n Pour déterminer la suite, répondez à l'énigme suivante:");
                riddleResolution = false;

                Console.WriteLine("Le chat est incapable de voir la zone située sous son nez, vrai(1) ou faux(2)");
                res = Console.ReadLine();
                if (res == "1")
                { riddleResolution = true; }
                Console.WriteLine("La réponse est VRAI. Bien que son angle de vision soit supérieur au nôtre, le chat est incapable de voir la zone située sous son nez.");
                if (riddleResolution)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(thery.Ragequit());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(thery.Cry());
                    Console.WriteLine(jerome.LooseLife(1));
                }
                Console.ResetColor();
                Console.WriteLine("Le cours se finit...");
                Console.ReadKey();

                Console.WriteLine("Le cours de " + papyCompta.Name + " commence");
                Console.WriteLine(papyCompta.Teach());
                Console.WriteLine(loic.ListenMusic());
                Console.WriteLine("2 possibilités, mais l'issue dépend du hasard \r\n Les dés sont jetés...");
                Console.ReadKey();
                dice = Dice.ThrowDice(1, 3);

                Console.ForegroundColor = ConsoleColor.Red;

                if (dice == 1)
                {
                    Console.WriteLine(papyCompta.HitTheTableWithARuler());
                    Console.WriteLine(loic.LooseLife(2));
                }
                else
                {
                    Console.WriteLine(loic.ThrowSomething());
                    Console.WriteLine(papyCompta.LooseLife(2));
                }
                Console.ResetColor();

                //  loop = false;
                Console.ReadKey();

                /* Test memento 
                 * 
                Console.WriteLine(mathilde.Life);
                mathilde.CreateMemento();
                Console.WriteLine(mathilde.Life);*/
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");

            foreach (Student std in listStudents)
            {
                if (std.Life <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bravo ! Vous avez poussé " + std.FirstName + " à bout");
                    Console.WriteLine("Les profs ont le pouvoir...");

                }
            }
            foreach (Teacher tch in listTeachers)
            {
                if (tch.Life <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bravo ! Vous avez poussé " + tch.Name + " à bout");
                    Console.WriteLine("Les élèves ont le pouvoir...");
                }
            }

            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
