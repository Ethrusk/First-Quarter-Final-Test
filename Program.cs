Console.WriteLine("Введите элементы массива через пробел:");
        string? input = Console.ReadLine();
        string[] inputArray = input!.Split( );

        string[] filteredArray = new string[inputArray.Length];
        int resultIndex = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                filteredArray[resultIndex] = str;
                resultIndex++;
            }
        }

        Array.Resize(ref filteredArray, resultIndex);

        
        Console.WriteLine("Результат:");
        foreach (string str in filteredArray)
        {
            Console.Write(str);
            Console.Write(", ");
        }