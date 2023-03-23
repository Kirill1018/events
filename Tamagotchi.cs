using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Exception;
using static System.Console;
namespace cs
{
    public class MyException : ApplicationException
    {
        public DateTime TimeException { get; private set; }
        public MyException() : base("ошибка")
        {
            TimeException = DateTime.Now;
        }
    }
    internal class Tamagotchi
    {
        private static System.Timers.Timer timer;
        private static void set_tim()
        {
            timer = new System.Timers.Timer(120000);
            timer.Elapsed += on_tim_event;
        }
        private static void on_tim_event(Object source, ElapsedEventArgs args)
        {
            WriteLine("игра закончена");
        }
        private static void feeding()
        {
            MessageBox.Show("прошу покормить");
        }
        private static void walking()
        {
            MessageBox.Show("прошу погулять");
        }
        private static void sleeping()
        {
            MessageBox.Show("прошу уложить спать");
        }
        private static void treatment()
        {
            MessageBox.Show("прошу полечить");
        }
        private static void game()
        {
            MessageBox.Show("прошу поиграть");
        }
        static void Main(string[] args)
        {
            WriteLine("_________$$$$$$$$$$___________________$$$$$$$$$$$\r\n______$$_______$$_$$________________$$____________ $\r\n_____$______________$______________$$_____________ _$\r\n____$_______________$__$$$$$$$$$$$$_______$$______ _$\r\n___$________$$______$$$__________________$$_______ $\r\n___$________$$$$_______________________$$$_______$\r\n___$________$____________________________$______$\r\n____$$_________________________________________$$\r\n______$$______________________________________$$\r\n_______$$______________________________________$\r\n_______$____________$___________________________$$\r\n______$_________$$____$$$$________$$____$________$ $\r\n______$____________$$_$___$______$__$$_$$$$$______ $\r\n______$______________$_$_$______$_$_$____________$ $\r\n______$________________$$$__$$$__$__$_____________ $\r\n______$______________$___$$$$__$$_$_______________ $\r\n_______$____________$____$$$$$$$$____$____________ $\r\n_______$___________$________$$_______$____________ $\r\n_______$___________$______________$__$___________$\r\n________$__________$__$$___$$__$$____$__________$\r\n________$__________$_______$___$$___$__________$\r\n__________$$________$_______$$$$___$______$$$$$$\r\n_______$$$___$$$_____$____________$_$$$$$$$_____$$\r\n_____$$____________$$$$$$$$$__$$$$$_________$$____ $$\r\n___$_____________$$_________$$__$_____________$___ __$\r\n___$$$________$$$_____________$$______________$$$_ ___$\r\n__$_________$$_$_______________________________$__ $__$\r\n_$_________$__$$$$$$_________ ________$$$$_$$__$______$\r\n_$$$_______$_$______$$______$$_____________$\r\n___$_________________$________________$$$$________ ___$\r\n___$$___________$$$$$$_$_______________$___$$$____ ___$\r\n____$__________________$________________$_________ ___$\r\n____$$$__________$$$$$$______________$$_$$$$$$____ __$$\r\n__$$___$$$___________$__$$__________$$___$______$$ $$$$\r\n_$________$$$$$$$$$$$$____$$______$$_______$$$$$__ _$$$$$$\r\n$$____________________$_____$___$$______________$$ $$$$___$\r\n_$____$$$__$$$________$______$$$_______________$__ ____$___$\r\n$$__$$________$________$______$____$__________$___ ____$___$\r\n$$__$__________$_______$___________$__________$___ ____$___$\r\n_$__$__________$_______$___________$__________$___ ____$___$\r\n__$__$_________$______$$$$$$$$$$$$$$$_________$___ ____$___$\r\n__$$_$$______$$_______$______________$_________$$_ ___$___$\r\n___$$__$$$$$________$$________________$$_________$ $$$___$\r\n_____$___________$$_____________________$$$$______ _____$\r\n______$$$$$$$$$$$___________________________");
            var rand_val = new Random();
            set_tim();
            int choice = rand_val.Next(3), selection, approvals = 0, rejections = 0;//согласия и отказы
            if (choice == 0)
            {
                feeding();
                WriteLine("0=отказ, 1=согласие");
                selection = Convert.ToInt32(ReadLine());
                if (selection == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                }
                if (selection == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
                choice++;
            }
            if (choice == 1)
            {
                walking();
                WriteLine("0=отказ, 1=согласие");
                selection = Convert.ToInt32(ReadLine());
                if (selection == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                }
                if (selection == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
                if (rejections == 0)
                {
                    feeding();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                }
                choice++;
            }
            if (choice == 2)
            {
                sleeping();
                WriteLine("0=отказ, 1=согласие");
                selection = Convert.ToInt32(ReadLine());
                if (selection == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                }
                if (selection == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
                if (rejections < 2)
                {
                    walking();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                    feeding();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                }
                choice++;
            }
            if (rejections == 3)
            {
                treatment();
                WriteLine("0=отказ, 1=согласие");
                int option = Convert.ToInt32(ReadLine());
                if (option == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                    WriteLine("персонаж умер");
                }
                if (option == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
            }
            if (choice == 3)
            {
                game();
                WriteLine("0=отказ, 1=согласие");
                selection = Convert.ToInt32(ReadLine());
                if (selection == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                }
                if (selection == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
                if (rejections < 3)
                {
                    sleeping();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                    walking();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                    feeding();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                    walking();
                    WriteLine("0=отказ, 1=согласие");
                    selection = Convert.ToInt32(ReadLine());
                    if (selection == 0)
                    {
                        rejections++;
                        WriteLine($"количество отказов={rejections}");
                    }
                    if (selection == 1)
                    {
                        approvals++;
                        WriteLine($"количество согласий={approvals}");
                    }
                }
            }
            if (rejections == 3)
            {
                treatment();
                WriteLine("0=отказ, 1=согласие");
                int option = Convert.ToInt32(ReadLine());
                if (option == 0)
                {
                    rejections++;
                    WriteLine($"количество отказов={rejections}");
                    WriteLine("персонаж умер");
                }
                if (option == 1)
                {
                    approvals++;
                    WriteLine($"количество согласий={approvals}");
                }
            }
        }
    }
}