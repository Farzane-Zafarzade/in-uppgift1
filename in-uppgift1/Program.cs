using System;
using System.Collections.Generic;

namespace ekvationen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ope = new string[3];
            int[] num = new int[4];
            int total = 0;
            string vilk;

            do
            {

                Console.Write(" > Enter first operator: ");
                ope[0] = Console.ReadLine();
                Console.WriteLine(ope[0]);
                Console.Write(" > Enter second operator: ");
                ope[1] = Console.ReadLine();
                Console.WriteLine(ope[1]);
                Console.Write(" > Enter first term: ");
                num[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num[0]);
                Console.Write(" > Enter second term: ");
                num[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num[1]);
                Console.Write(" > Enter third term: ");
                num[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num[2]);
                string[] sum = new string[7];
                sum[0] = Convert.ToString(num[0]);
                sum[1] = ope[0];
                sum[2] = Convert.ToString(num[1]);
                sum[3] = ope[1];
                sum[4] = Convert.ToString(num[2]);
                sum[5] = "=";





                if (ope[0] == "+" && ope[1] == "+")
                {
                    num[3] = num[0] + num[1] + num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];


                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };



                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }



                }
                else
                    if (ope[0] == "+" && ope[1] == "-")
                {
                    num[3] = num[0] + num[1] - num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "+" && ope[1] == "*")
                {
                    num[3] = num[0] + num[1] * num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "+" && ope[1] == "/")
                {
                    num[3] = num[0] + num[1] / num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "-" && ope[1] == "+")
                {
                    num[3] = num[0] - num[1] + num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "-" && ope[1] == "-")
                {
                    num[3] = num[0] - num[1] - num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }

                }
                else
                    if (ope[0] == "-" && ope[1] == "*")
                {
                    num[3] = num[0] - num[1] * num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "-" && ope[1] == "/")
                {
                    num[3] = num[0] - num[1] / num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];


                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "*" && ope[1] == "+")
                {
                    num[3] = num[0] * num[1] + num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "*" && ope[1] == "-")
                {
                    num[3] = num[0] * num[1] - num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "*" && ope[1] == "*")
                {
                    num[3] = num[0] * num[1] * num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "*" && ope[1] == "/")
                {
                    num[3] = num[0] * num[1] / num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }

                else
                    if (ope[0] == "/" && ope[1] == "+")
                {
                    num[3] = num[0] / num[1] + num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "/" && ope[1] == "-")
                {
                    num[3] = num[0] / num[1] - num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "/" && ope[1] == "*")
                {
                    num[3] = num[0] / num[1] * num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }
                else
                    if (ope[0] == "/" && ope[1] == "/")
                {
                    num[3] = num[0] / num[1] / num[2];
                    sum[6] = Convert.ToString(num[3]);
                    total = total + num[3];

                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(sum[i]);
                    };

                    if (num[3] < 100)
                    {
                        Console.WriteLine("”The sum is less then a hundred”");
                    }
                    else
                        if (num[3] > 100)
                    {
                        Console.WriteLine("”The sum is more then a hundred”");
                    }
                    else
                        if (num[3] == 100)
                    {
                        Console.WriteLine("”Cool, now you have a hundred, clap clap”");
                    }
                }


                Console.WriteLine("Another try? Y / N");
                vilk = Console.ReadLine();


            } while (vilk == "y");
            Console.Write("> Thank you for playing. The sum of all round is");
            Console.Write(total);
            Console.WriteLine("bye.");
            Console.ReadKey();
        }
    }
}
