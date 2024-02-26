    Console.Write("Enter Qestion Number to Get The desired program i.e. -1.for Traingle Pattern and 2.for get date from the given string : ");
    string userInput = Console.ReadLine();

    if(Convert.ToInt32(userInput)==1){
        Console.Write("Enter the number of lines to print");
        string RowStr = Console.ReadLine();
         int i, j, row = Convert.ToInt32(RowStr);
        for (i=0; i<row; i++)
        {
            for (j=row-i; j>1; j--)
            {
                Console.Write(" ");
            }
            for (int k=0; k<=i; k++ )
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
        else if(Convert.ToInt32(userInput)==2){
          Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int length = input.Length;
        for (int i = 0; i < length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                string potentialDate = "";

                for (int j = i; j < length && char.IsDigit(input[j]); j++)
                {
                    potentialDate += input[j];
                }
                if (potentialDate.Length == 8)
                {
                    int month = int.Parse(potentialDate.Substring(0, 2));
                    int day = int.Parse(potentialDate.Substring(2, 2));
                    int year = int.Parse(potentialDate.Substring(4, 4));

                    if (month >= 1 && month <= 12 && day >= 1 && day <= DateTime.DaysInMonth(year, month))
                    {
                        Console.WriteLine("Valid date: " + potentialDate);
                    }
                }
            }
        }
    
    
    }

    

