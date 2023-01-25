﻿using System;
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
                Console.WriteLine("2) restituisce la stringa dell' HTML di un array inserito");
                Console.WriteLine("3) Ricerca un numero all'interno di un'array, da la posizione se lo trova, o scrive se non lo trova");
                Console.WriteLine("4) Cancellazione di un elemento dell'array");
                Console.WriteLine("5) Inserimento di un valore in una posizione dell'array");
                Console.WriteLine("6) Aggiungere all'array numeri random compresi tra valori inseriti");
                Console.WriteLine("7) Troncamento di un array, data una dimensione inseriti");
                Console.WriteLine("8) Ordinare un array inserimento per inserimento");
                Console.WriteLine("0) Termina programma ");

                Console.Write("\nSeleziona una delle precedenti funzioni scrivendo il numero qua: ");
                int fun; //scelta funzione
                //char aut = 'f'; //un numero e autoinvia
                //aut = Console.ReadKey().KeyChar;
                //Task.Delay(350).Wait();
                //while (!int.TryParse(aut.ToString(), out fun) || !(fun >= 0 && fun <= 5))

                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out fun) || !(fun >= 0 && fun <= 8))
                {//bad input
                    Task.Delay(300).Wait();
                    Console.SetCursorPosition(65, 8);
                    Console.Write("numero intero tra 0 e 8");
                    Console.SetCursorPosition(65, 7);
                    Console.Write(" ");
                    Console.SetCursorPosition(65, 7);
                    //aut = Console.ReadKey().KeyChar;
                    //Task.Delay(350).Wait();
                }
                Task.Delay(500).Wait();

                switch (fun)
                {


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

                    case 6:
                        Console.Clear();
                        F3();
                        break;

                    case 7:
                        Console.Clear();
                        F4();
                        break;

                    case 8:
                        Console.Clear();
                        F5();
                        break;

                    default:
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Fine programma...");
                        rpr = false;
                        break;

                }

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (rpr);
        }

        //stampa pre programma
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
            float[] arr1 = new float[20];
            int cou = 0; //counter
            do
            {
                Console.SetCursorPosition(0, 4);
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Array1(arr1, cou);
                    cou++;
                }
                else
                {
                    //Console.SetCursorPosition(0, Console.CursorTop);
                    //Console.Write(new string(' ', Console.WindowWidth));
                    //Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                    Console.Write("\r \n"); // "\r" torna a inizio riga??
                    Console.WriteLine("Fine funzione...");
                    break;
                }

                Console.Clear();
                Console.Write("1) Aggiungere in coda un elemento all'array (decimali)\n\nL'array adesso ha: ");
                for (int i = 0; i < cou; i++) Console.Write(arr1[i] + " | ");
                if (cou == arr1.Length)
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
            int p = 100;
            int[] arr3 = RandomArray(p, 0, 100);
            Console.WriteLine("3) Ricerca un numero all'interno di un'array, da la posizione se lo trova, o scrive se non lo trova" +
                "\n\nvuoi cercare un numero?(scrivi (y)es per cercare, altro per no) ");
            do
            {
                //Console.Clear();

                Console.SetCursorPosition(0, 3);
                if (Console.ReadKey().KeyChar == 'y') p = Array3(arr3);
                else
                {
                    Console.Write("\b \n");
                    Console.WriteLine("Fine funzione...");
                    break;
                }
                if (p != -1) Console.Write($"\nL'elemento {arr3[p]} si trova in posizione {p}\npremi per continuare");
                else Console.Write("\nL'elemento non si trova nell'array\npremi per continuare");
                Console.ReadKey();
                for (int y = 3; y <= 6; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
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

        //crea un array di interi random
        static int[] RandomArray(int lunghezza, int min, int max)
        {
            Random R = new Random();
            int[] arr = new int[lunghezza];
            for (int i = 0; i < lunghezza; i++)
            {
                arr[i] = R.Next(min, max + 1);
                Task.Delay(1).Wait(); //debug
            }
            return arr;
        }

        //Cancellazione di un elemento dell'array
        static void F4()
        {
            int lun = 20; //lunghezza array disponibile
            int[] arr4 = RandomArray(lun + 1, 0, 99); //lunghezza + 1 per l'errore in spostamento
            Console.WriteLine("4) Cancellazione di un elemento dell'array\n\nvuoi cancellare un numero?(scrivi (y)es per cancellare, altro per no)");

            do
            {
                Console.SetCursorPosition(0, 8);
                for (int i = 0; i < lun; i++) Console.Write(arr4[i] + " | ");

                lun--;
                Console.SetCursorPosition(0, 3);
                if (Console.ReadKey().KeyChar == 'y') Array4(arr4, lun);
                else
                {
                    Console.Write("\b \n");
                    Console.WriteLine("Fine funzione...");
                    break;
                }

                if (lun == 0)
                {
                    Console.SetCursorPosition(0, 8);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.WriteLine("\n l'array è vuoto\nFine funzione...");
                    break;
                }

                for (int y = 3; y <= 8; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            } while (true);
        }
        static void Array4(int[] arr, int lun)
        {
            do
            {
                int iar = 100; //indice array
                int nsc; //numero scelto

                Console.Write("\bnumero da cancellare: ");
                while (!int.TryParse(Console.ReadLine(), out nsc) || !(nsc >= 0 && nsc < 100))
                {//bad input
                    Task.Delay(300).Wait();
                    Console.SetCursorPosition(22, 4);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(22, 4);
                    Console.Write("numero intero tra 0 e 99");
                    Console.SetCursorPosition(22, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(22, 3);

                }
                Task.Delay(600).Wait();

                //for (int i = 0; i <= lun; i++) if (arr[i] == nsc) iar = i;
                //for (int i = 0; i < lun; i++) if (i >= iar) arr[i] = arr[i + 1];
                for (int i = lun; i >= 0; i--) if (arr[i] == nsc)
                    {
                        iar = i;
                        break; //quella più a destra
                    }
                for (int i = iar; i < lun; i++) arr[i] = arr[i + 1];

                if (iar == 100)
                {
                    Console.SetCursorPosition(22, 4);
                    Console.Write("il numero non è presente nell'array");
                    Console.SetCursorPosition(22, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, 3);
                }
                else break;
            } while (true);
        }

        //Inserimento di un valore in una posizione dell'array
        static void F5()
        {
            int lum = 20; //lunghezza massima array
            int[] arr5 = new int[lum + 1]; //serve +1?
            int lun = 0; //lunghezza array usato
            Console.WriteLine("5) Inserimento di un valore in una posizione dell'array.\nInserendo un elemento con array pieno(20) il valore in fondo verrà eliminato" +
                "\n\nvuoi aggiungere un numero ? (scrivi(y)es per aggiungere, altro per no)");
            do
            {
                Console.SetCursorPosition(0, 8);
                for (int i = 0; i < lun; i++) Console.Write(arr5[i] + " | ");

                if (lun != lum) lun++;
                Console.SetCursorPosition(0, 4);
                if (Console.ReadKey().KeyChar == 'y') Array5(arr5, lun, lum);
                else
                {
                    Console.Write("\b \n");
                    Console.WriteLine("Fine funzione...");
                    break;
                }

                Console.SetCursorPosition(0, 9);
                if (lun == lum) Console.Write("L'array è pieno");

                for (int y = 4; y <= 8; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(new string(' ', Console.WindowWidth));
                }

            } while (true);
        }
        static void Array5(int[] arr, int lun, int lum)
        {
            int isc; //indice scelto
            int nsc; //numero scelto

            Console.Write("\bposizione in cui scrivere il numero: ");
            while (!int.TryParse(Console.ReadLine(), out isc) || !(isc >= 0 && isc < lun))
            {//bad input
                Task.Delay(300).Wait();
                Console.SetCursorPosition(37, 5);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(37, 5);
                Console.Write($"numero intero tra 0 e {lun - 1}");
                Console.SetCursorPosition(37, 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(37, 4);
            }
            Task.Delay(600).Wait();
            Console.SetCursorPosition(0, 5);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 5);

            Console.Write("numero da inserire: ");
            while (!int.TryParse(Console.ReadLine(), out nsc) || !(nsc >= 0 && nsc < 100))
            {//bad input
                Task.Delay(300).Wait();
                Console.SetCursorPosition(20, 6);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(20, 6);
                Console.Write("numero intero tra 0 e 99");
                Console.SetCursorPosition(20, 5);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(20, 5);
            }
            Task.Delay(600).Wait();

            for (int i = lum - 1; i >= isc; i--) arr[i + 1] = arr[i];
            arr[isc] = nsc;
        }

        //Aggiungere all'array numeri random compresi tra valori inseriti
        static void F6()
        {
            int[] arr6 = new int[20];
            int lun = 0; //lunghezza array usato
            Console.WriteLine("6) Aggiungere all'array numeri random compresi tra valori inseriti\n\nvuoi creare un nuovo array? (scrivi(y)es per aggiungere, altro per no)");
            do
            {

                Console.SetCursorPosition(0, 8);
                for (int i = 0; i < lun; i++) Console.Write(arr6[i] + " | ");

                Console.SetCursorPosition(0, 3);
                if (Console.ReadKey().KeyChar == 'y') Array6(arr6, lun);
                else
                {
                    Console.Write("\b \n");
                    Console.WriteLine("Fine funzione...");
                    break;
                }

                for (int y = 3; y <= 8; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            } while (true);
        }

        static void Array6(int[] arr, int lun)
        {
            Random rnd = new Random();
            int min, max;

            Console.Write("\binserisci minimo e massimo: ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {//bad input
                Console.SetCursorPosition(21, 5);
                Console.Write("numero decimale");
                Console.SetCursorPosition(21, 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(21, 4);
            }
            //get left per non cancellare il min a schermo,
            Console.Write(" | ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {//bad input
                Console.SetCursorPosition(21, 5);
                Console.Write("numero decimale");
                Console.SetCursorPosition(21, 4);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(21, 4);
            }
            //if max e min da invertire?
        }

        static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot) i++;

                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
    }
}