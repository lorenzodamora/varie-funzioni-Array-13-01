using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            bool rpr; //ripeti programma
            do
            {
                rpr = true;
                Console.WriteLine("1) Aggiungere in coda un elemento all'array (decimali)");
                Console.WriteLine("2) restituisce la stringa dell' HTML di un array scritto da te");
                Console.WriteLine("3) Ricerca un numero all'interno di un'array, restituisce la posizione dell'elemento se lo trova, o scrive se non lo trova");
                Console.WriteLine("4) Cancellazione di un elemento dell'array");
                Console.WriteLine("5) Inserimento di un valore in una posizione dell'array");
                Console.WriteLine("0) Termina programma ");

                Console.Write("\nSeleziona una delle precedenti funzioni scrivendo il numero qua: ");
                int fun; //scelta funzione
                //char aut = 'f'; //un numero e autoinvia
                //aut = Console.ReadKey().KeyChar;
                //Task.Delay(350).Wait();
                //while (!int.TryParse(aut.ToString(), out fun) || !(fun >= 0 && fun <= 5))

                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out fun) || !(fun >= 0 && fun <= 5))
                {//bad input
                    Task.Delay(300).Wait();
                    Console.SetCursorPosition(65, 9);
                    Console.Write("numero intero tra 0 e 5");
                    Console.SetCursorPosition(65, 8);
                    Console.Write("                                ");
                    Console.SetCursorPosition(65, 8);
                    //aut = Console.ReadKey().KeyChar;
                    //Task.Delay(350).Wait();
                }
                Task.Delay(500).Wait();

                switch (fun)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Fine programma...");
                        rpr = false;
                        break;

                    case 1:
                        Console.Clear();
                        F1();
                        break;

                    case 2:
                        Console.Clear();
                        F2();
                        break;

                    case 3:
                        Console.Clear();
                        F3();
                        break;

                    case 4:
                        Console.Clear();
                        F4();
                        break;

                    case 5:
                        Console.Clear();
                        F5();
                        break;
                }

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (rpr);
        }
        //stampa pre progamma
        static void Start()
        {
            Console.BackgroundColor = ConsoleColor.Red;//setta il colore di sfondo
            Console.Clear(); //colora tutto
            Console.ForegroundColor = ConsoleColor.Black;//setta il colore del carattere
            Console.SetCursorPosition(10, 1);//setta la posizione del cursore;
            Console.Write("FUNZIONI CON ARRAY VARIE\n\n press any key to continue");
            //Console.ReadKey();//press any key to continue
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("prima di cominciare mettere schermo intero e poi premere un tasto per continuare");
            //Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
        // Aggiungere in coda un elemento all'array (interi);
        static void F1()
        {
            Console.WriteLine("1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso è vuoto!" +
                    "\nvuoi caricare un numero?(scrivi (y)es per caricare, qualsiasi altra cosa per no ");
            float[] array = new float[20];
            int cou = 0; //counter
            do
            {
                Console.SetCursorPosition(0, 4);
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Array1(array, cou);
                    cou++;
                }
                else
                {
                    //Console.SetCursorPosition(0, Console.CursorTop);
                    //Console.Write(new string(' ', Console.WindowWidth));
                    //Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                    Console.Write("\r \n"); // "\r" torna a inizio riga
                    Console.WriteLine("Fine funzione...");
                    break;
                }

                Console.Clear();
                Console.Write("1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso ha: ");
                for (int i = 0; i < cou; i++) Console.Write(array[i] + " | ");
                if (cou == array.Length)
                {
                    Console.WriteLine("\nL'array è pieno\nFine funzione...");
                    Console.ReadKey();
                    break;
                }
                else Console.Write("\nvuoi caricare un numero?(scrivi (y)es per caricare, altro per no) ");

            } while (true);
        }
        static void Array1(float[] arr, int cou)
        {
            Console.Write("\binserisci un numero: ");
            while (!float.TryParse(Console.ReadLine(), out arr[cou]))
            {//bad input
                Console.SetCursorPosition(21, 5);
                Console.Write("numero decimale");
                Console.SetCursorPosition(21, 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(21, 4);
            }
        }

        //Visualizzazione dell'array che restituisca la stringa in HTML;
        static void F2()
        {
            Console.WriteLine("Non l'ho fatto");
            Task.Delay(300).Wait();
        }

        //Ricerca un numero all'interno di un'array, restituisce la posizione dell'elemento se lo trova, o scrive se non lo trova
        static void F3()
        {
            Random R = new Random();
            int[] arr1 = new int[50];
            int p=0; //posizione
            foreach (int i in arr1)
            {
                arr1[p] = R.Next(0, 101);
                p++;
                //Task.Delay(1).Wait();
            }
            do
            {
                Console.Clear();
                Console.WriteLine("3) Ricerca un numero all'interno di un'array, da la posizione se lo trova, o scrive se non lo trova" +
                "\n\nvuoi cercare un numero?(scrivi (y)es per cercare, altro per no) ");
                Console.SetCursorPosition(0, 3);
                if (Console.ReadKey().KeyChar == 'y') p = Array3(arr1);
                else
                {
                    Console.Write("\b \n");
                    Console.WriteLine("Fine funzione...");
                    break;
                }
                if(p!=-1) Console.Write($"\nL'elemento {arr1[p]} si trova in posizione {p}\npremi per continuare");
                else Console.Write("\nL'elemento non si trova nell'array\npremi per continuare");
                Console.ReadKey();
            } while (true);

        }
        static int Array3(int[] arr1)
        {
            Console.Write("\bricerca un numero: ");
            int num = -1; //numero provato
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 100)
            {//bad input
                Task.Delay(300).Wait();
                Console.SetCursorPosition(19, 4);
                Console.Write("numero intero tra 0 e 100");
                Console.SetCursorPosition(19, 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(19, 3);
            }
            Task.Delay(600).Wait();

            int i = 0;//indice
            foreach (var n in arr1)
            {
                if (n == num) return i;
                i++;
            }
            return -1;
        }

        static void F4()
        {

        }
        static void F5()
        {

        }
    }
}