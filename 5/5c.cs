//if given that this is the row after which the reverse triangle happens
            int n = 5;

            //another solution in case we need to avoid extra conditional statement.
            // but each time i's value does get checked
            for (int i = 1; i < 2 * n; i++)
            {
                for (int j = 1; j <= (i > 5 ? 2 * n - i : i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();