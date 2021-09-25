int count = 9;

            for (int i = 1; i <= count; i++)
            {
                if (i > 5)
                {
                    for (int j = 1; j <= count-i+1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();