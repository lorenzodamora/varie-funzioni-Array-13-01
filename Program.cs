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
                while (!int.TryParse(Console.ReadLine(), out fun) || !(fun >= 0 && fun <= 5))
                {//bad input
                    Console.SetCursorPosition(65, 9);
                    Console.Write("numero intero tra 0 e 5");
                    Console.SetCursorPosition(65, 8);
                    Console.Write("                                ");
                    Console.SetCursorPosition(65, 8);
                }

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
                Console.Write($"1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso ha: ");
                for (int i = 0; i < cou; i++) Console.Write(array[i] + " | ");
                if (cou == array.Length)
                {
                    Console.WriteLine("\nL'array è pieno\nFine funzione...");
                    break;
                }
                else
                {
                    Console.Write("\nvuoi caricare un numero?(scrivi (y)es per caricare, altro per no) ");
                }

            } while (true);
        }
        static void Array1(float[] arr, int cou)
        {
            Console.CursorLeft = 0;
            Console.Write("inserisci un numero: ");
            while (!float.TryParse(Console.ReadLine(), out arr[cou]))
            {//bad input
                Console.SetCursorPosition(21, 5);
                Console.Write("numero decimale");
                Console.SetCursorPosition(21, 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(21, 4);
            }
        }
        static void F2()
        {

        }
        static void F3()
        {
            //string
        }
        static void F4()
        {

        }
        static void F5()
        {

        }
    }
}