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
            //ciclo do while?
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
                    Console.WriteLine("Fine programma");
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
                    F5();
                    Console.Clear();
                    break;
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
                    Array1(array,cou);
                    cou++;
                }
                else
                {
                    Console.WriteLine("Fine programma");
                    break;
                }
                Console.Clear();
                //if max 20 inserimenti??
                Console.WriteLine($"1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso ha:" +
                "\nvuoi caricare un numero?(scrivi (y)es per caricare, qualsiasi altra cosa per no ");
                Console.SetCursorPosition(19, 2);
                for (int i = 0;i<cou;i++) Console.Write(array[i]+" | ");

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
                Console.Write("                                ");
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
