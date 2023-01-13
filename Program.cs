using System;
using System.Collections.Generic;
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
            Console.WriteLine("1) Aggiungere in coda un elemento all'array (decimali)");
            Console.WriteLine("2) restituisce la stringa dell' HTML di un array scritto da te");
            Console.WriteLine("3) Ricerca un numero all'interno di un'array, restituisce la posizione dell'elemento se lo trova, o scrive se non lo trova");
            Console.WriteLine("4) Cancellazione di un elemento dell'array");
            Console.WriteLine("5) Inserimento di un valore in una posizione dell'array");
            Console.WriteLine("0) Termina programma ");

            Console.Write("\nSeleziona una delle precedenti funzioni scrivendo il numero qua: ");
            int c; 
            while (!int.TryParse(Console.ReadLine(), out c) || !(c >= 0 && c <= 5))
            {//bad input
                Console.SetCursorPosition(65, 9);
                Console.Write("numero intero positivo tra 0 e 5");
                Console.SetCursorPosition(65, 8);
                Console.Write("                                ");
                Console.SetCursorPosition(65, 8);
            }
            Console.SetCursorPosition(65, 9);
            Console.Write("                                ");

            switch (c)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Fine programma");
                    break;

                case 1:
                    Console.Clear();
                    Array1();
                    break;

                case 2:
                    Console.Clear();
                    Array2();
                    break;

                case 3:
                    Console.Clear();
                    Array3();
                    break;

                case 4:
                    Console.Clear();
                    Array4();
                    break;

                case 5:
                    Array5();
                    Console.Clear();
                    break;

                default: break;
            }
        }
        //stampa pre progamma
        static void Start()
        {
            Console.BackgroundColor = ConsoleColor.Red;//setta il colore di sfondo
            Console.Clear(); //colora tutto
            Console.ForegroundColor = ConsoleColor.Black;//setta il colore del carattere
            Console.SetCursorPosition(10, 1);//setta la posizione del cursore;
            Console.Write("FUNZIONI CON ARRAY VARIE\n\n press any key to continue");
            Console.ReadKey();//press any key to continue
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("prima di cominciare mettere schermo intero e poi premere un tasto per continuare");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
        // Aggiungere in coda un elemento all'array (interi);
        static void Array1()
        {
            Console.WriteLine("1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso è vuoto!\nvuoi caricare un numero?");
            float[] array = new float[20];
            Console.WriteLine("")
        }
        static void Array2()
        {

        }
        static void Array3()
        {
            //string
        }
        static void Array4()
        {

        }
        static void Array5()
        {

        }
    }
}
