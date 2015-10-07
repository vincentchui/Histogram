using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        private double[] counter = new double[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public void menu()
        {
            string choice;
            int randomI;
            double randomD;
            int cumI = 0;
            Random r = new Random();

            do
            { 
                Console.Write("\nPlot" +
                "\nReset" +
                "\nQuit");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "plot":
                        do
                        {
                            Console.Write("\nFrequency or Cumulative: ");
                            choice = Console.ReadLine().ToLower();

                            if (choice == "frequency")
                            {
                                for (int i = 0; i < 10000; i++)
                                {
                                    randomD = r.NextDouble();
                                    freqCounter(randomD);
                                }
                            }
                            else if (choice == "cumulative")
                            {
                                for (int i = 0; i < 1000; i++)
                                {
                                    for (int x = 0; x < 10; x++)
                                    {
                                        randomI = r.Next(0, 10);
                                        cumI += randomI;
                                    }
                                    cumCounter(cumI);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nINVALID INPUT");
                            }
                        } while ((choice != "frequency") || (choice != "cumulative"));
                        break;
                    case "reset":
                        reset();
                        break;
                    case "quit":
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break; 
                }
            } while (choice != "quit");
        }

        public void readCounter()
        {
            Console.WriteLine(
                "\n\t\tRange\t\t\tCount" +
                "\n  0 <= x < 0.1" + "\t\t" + counter[0] + 
                "\n0.1 <= x < 0.2" + "\t\t" + counter[1] +
                "\n0.2 <= x < 0.3" + "\t\t" + counter[2] +
                "\n0.3 <= x < 0.4" + "\t\t" + counter[3] +
                "\n0.4 <= x < 0.5" + "\t\t" + counter[4] +
                "\n0.5 <= x < 0.6" + "\t\t" + counter[5] +
                "\n0.6 <= x < 0.7" + "\t\t" + counter[6] +
                "\n0.7 <= x < 0.8" + "\t\t" + counter[7] +
                "\n0.8 <= x < 0.9" + "\t\t" + counter[8] +
                "\n0.9 <= x < 1.0" + "\t\t" + counter[9]);
        }
            
        public void cumCounter(int x)
        {
            if ((0 <= x) && (x < 1))
            {
                counter[0]++;
            }
            else if ((1 <= x) && (x < 2))
            {
                counter[1]++;
            }
            else if ((2 <= x) && (x < 3))
            {
                counter[2]++;
            }
            else if ((3 <= x) && (x < 4))
            {
                counter[3]++;
            }
            else if ((4 <= x) && (x < 5))
            {
                counter[4]++;
            }
            else if ((5 <= x) && (x < 6))
            {
                counter[5]++;
            }
            else if ((6 <= x) && (x < 7))
            {
                counter[6]++;
            }
            if ((7 <= x) && (x < 8))
            {
                counter[7]++;
            }
            if ((8 <= x) && (x < 9))
            {
                counter[8]++;
            }
            if ((9 <= x) && (x < 10))
            {
                counter[9]++;
            }
            else
            {
                Console.WriteLine("\nNumber out of range");
            }
        }

        public void freqCounter(double x)
        {
            if((0 <= x) && (x < 0.1))
            {
                counter[0]++;
            }
            else if ((0.1 <= x) && (x < 0.2))
            {
                counter[1]++;
            }
            else if ((0.2 <= x) && (x < 0.3))
            {
                counter[2]++;
            }
            else if ((0.3 <= x) && (x < 0.4))
            {
                counter[3]++;
            }
            else if ((0.4 <= x) && (x < 0.5))
            {
                counter[4]++;
            }
            else if ((0.5 <= x) && (x < 0.6))
            {
                counter[5]++;
            }
            else if ((0.6 <= x) && (x < 0.7))
            {
                counter[6]++;
            }
            if ((0.7 <= x) && (x < 0.8))
            {
                counter[7]++;
            }
            if ((0.8 <= x) && (x < 0.9))
            {
                counter[8]++;
            }
            if ((0.9 <= x) && (x < 1))
            {
                counter[9]++;
            }
            else
            {
                Console.WriteLine("\nNumber out of range");
            }
        }

        public void add(double x)
        {
            x = x + 1;
        }

        public void reset()
        {
            for(int i = 0; i < 9; i++)
            {
                counter[i] = 0;
            }

        }

        public void plotFrequency()
        {

        }

        public void plotCumlative()
        {

        }

    }
}
/*OUTPUT
*/