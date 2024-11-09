using System.Security.Cryptography.X509Certificates;

namespace Interface._5_11
{
    class Program
    {
        static void Main()
        {
            int[] arrayElements = { 1, 2, 3, 4, 5 }; Array myArray = new Array(arrayElements);

            myArray.Show();
            myArray.Show("----=-=-=");

            Console.WriteLine($"Less {myArray.Less(3)} / {myArray.EqualT(4)}");
            myArray.ShowOdd();
            Console.WriteLine(myArray.CountDistinct());
            
        }
        class Array : ICalc, IOutput, IOutput2 , ICalc2
        {
            private int[] elements;

            public Array(int[] list)
            {
                this.elements = list;
            }
            public void Show()
            {
                Console.WriteLine("Elements ->");
                for (int i = 0; i < elements.Length; i++)
                {
                    Console.Write($" {elements[i]} |");
                }
                Console.WriteLine();
            }
            public void Show(string info)
            {
                Show(); Console.WriteLine(info);
            }

            public int Less(int valueToCompare)
            {
                int count = 0;
                foreach(var element in elements)
                {
                    if(element < valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }
            public int Greater(int valueToCompare)
            {
                int count = 0;
                foreach (var element in elements)
                {
                    if (element > valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }

            public void ShowEven()
            {
                Console.WriteLine("Even ");
                foreach(var element in elements)
                {
                    if(element% 2 == 0)
                    {
                        Console.WriteLine($"+ {element} +");
                    }
                }
                Console.WriteLine();

            }
            public void ShowOdd()
            {
                Console.WriteLine("Odd ");
                foreach (var element in elements)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write($"- {element} -");
                    }
                }
                Console.WriteLine();

            }

            public int CountDistinct()
            {
                int count = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    bool un = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (elements[i] == elements[j])
                        {
                            un = false;
                            break;
                        }
                    }

                    if (un)
                        count++;
                }

                return count;
            }

            public int EqualT(int value)
            {
                int c = 0;
                foreach(var element in elements)
                {
                    if(element == value)
                    {
                        c++;
                    }
                    
                }
                return c;
            }
        }
        public interface IOutput
        {
            void Show(); void Show(string message);
        }

        public interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }
        public interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }
        public interface ICalc2
        {
            int CountDistinct();
            int EqualT(int value);
        }
    }
}
