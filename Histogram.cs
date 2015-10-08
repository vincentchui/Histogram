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
            double random;
            double cum = 0;
            Random r = new Random();

            printInfo();

            do
            { 
                Console.Write("\nPlot" +
                "\nReset" +
                "\nQuit" +
                "\nEnter an choice: ");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "plot":
                        do
                        {
                            Console.Write("\nFrequency, Cumulative, or Quit: ");
                            choice = Console.ReadLine().ToLower();

                            if (choice == "frequency")
                            {
                                for (int i = 0; i < 10000; i++)
                                {
                                    random = r.NextDouble();
                                    freqCounter(random);
                                }
                                readCounter();

                                reset();
                            }
                            else if (choice == "cumulative")
                            {
                                for (int i = 0; i < 1000; i++)
                                {
                                    for (int x = 0; x < 10; x++)
                                    {
                                        random = r.NextDouble();
                                        cum += random;
                                    }
                                    cumCounter(cum);
                                    cum = 0;
                                }
                                readCounter();

                                reset();
                            }
                            else if(choice == "quit")
                            {
                                menu();
                            }
                            else
                            {
                                Console.WriteLine("\nINVALID INPUT");
                            }
                        } while ((choice != "frequency") || (choice != "cumulative"));
                        break;
                    case "reset":
                        Console.WriteLine("\nCounters reseted");
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
                "\n\tRange\t\tCount" +
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
            
        public void cumCounter(double x)
        {
            if ((0 <= x) && (x < 1))
            {
                add(0);
            }
            else if ((1 <= x) && (x < 2))
            {
                add(1);
            }
            else if ((2 <= x) && (x < 3))
            {
                add(2);
            }
            else if ((3 <= x) && (x < 4))
            {
                add(3);
            }
            else if ((4 <= x) && (x < 5))
            {
                add(4);
            }
            else if ((5 <= x) && (x < 6))
            {
                add(5);
            }
            else if ((6 <= x) && (x < 7))
            {
                add(6);
            }
            else if ((7 <= x) && (x < 8))
            {
                add(7);
            }
            else if ((8 <= x) && (x < 9))
            {
                add(8);
            }
            else 
            {
                add(9);
            }
        }

        public void freqCounter(double x)
        {
            if((0 <= x) && (x < 0.1))
            {
                add(0);
            }
            else if ((0.1 <= x) && (x < 0.2))
            {
                add(1);
            }
            else if ((0.2 <= x) && (x < 0.3))
            {
                add(2);
            }
            else if ((0.3 <= x) && (x < 0.4))
            {
                add(3);
            }
            else if ((0.4 <= x) && (x < 0.5))
            {
                add(4);
            }
            else if ((0.5 <= x) && (x < 0.6))
            {
                add(5);
            }
            else if ((0.6 <= x) && (x < 0.7))
            {
                add(6);
            }
            else if ((0.7 <= x) && (x < 0.8))
            {
                add(7);
            }
            else if ((0.8 <= x) && (x < 0.9))
            {
                add(8);
            }
            else
            {
                add(9);
            }
        }

        public void add(double i)
        {
            counter[(int) i]++;
        }

        public void reset()
        {
            for(int i = 0; i < 9; i++)
            {
                counter[i] = 0;
            }

        }

        public void printInfo()
        {
            Console.WriteLine("\nWritten by Vincent Chui" +
                "\nCIS 23 Fall 2015 BCC");
        }
    }
}
/*OUTPUT

Written by Vincent Chui
CIS 23 Fall 2015 BCC

Plot
Reset
Quit
Enter an choice: plot

Frequency, Cumulative, or Quit: d

INVALID INPUT

Frequency, Cumulative, or Quit: frequency

        Range           Count
  0 <= x < 0.1          983
0.1 <= x < 0.2          1004
0.2 <= x < 0.3          1012
0.3 <= x < 0.4          1011
0.4 <= x < 0.5          1045
0.5 <= x < 0.6          983
0.6 <= x < 0.7          1006
0.7 <= x < 0.8          1004
0.8 <= x < 0.9          928
0.9 <= x < 1.0          1024

Frequency, Cumulative, or Quit: cumulative

        Range           Count
  0 <= x < 0.1          0
0.1 <= x < 0.2          0
0.2 <= x < 0.3          7
0.3 <= x < 0.4          124
0.4 <= x < 0.5          364
0.5 <= x < 0.6          360
0.6 <= x < 0.7          137
0.7 <= x < 0.8          8
0.8 <= x < 0.9          0
0.9 <= x < 1.0          1024

Frequency, Cumulative, or Quit: quit

Plot
Reset
Quit
Enter an choice: reset

Counters reseted

Plot
Reset
Quit
Enter an choice: quit

Goodbye

Frequency, Cumulative, or Quit:
*/
