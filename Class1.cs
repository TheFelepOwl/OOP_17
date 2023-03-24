using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace OOP_17
{
    namespace CrossFigure
    {

        namespace CrossFigure
        {
            [Serializable]
            public class Cross
            {
                public int A { get; set; }
                public int B { get; set; }

                public Cross()
                {
                    A = 0;
                    B = 0;
                }

                public Cross(int a, int b)
                {
                    A = a;
                    B = b;
                }

                public void Draw()
                {
                    Console.WriteLine("\n\n Cross:");

                    for (int i = 0; i < A; i++)
                    {
                        for (int j = 0; j < B; j++)
                        {
                            if (i == A / 2 || j == B / 2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}