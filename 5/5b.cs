//if given that this is the row after which the reverse triangle happens
            int n = 5;

            for (int i = 1; i < 2 * n; i++)
            {
                if (i > 5)
                {
                    for (int j = 1; j < 2 * n - i + 1; j++)
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
        }