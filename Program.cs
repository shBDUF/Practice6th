// Console.WriteLine("Введите цифры - ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("Количество цифр больше нуля -> {0}", count);


// Console.WriteLine("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2-b1)/(k2-k1);
// double y = k1*x+b1;
// Console.WriteLine("Точка пересечения прямых - ({0};{1})",x,y);


// Console.WriteLine("Введите число: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// int[] Fibbonachi = new int[2]{1,1};
// int[] NegaFibbonachi= new int[2]{0, 1};
// Array.Resize(ref Fibbonachi, inputNumber);
// Array.Resize(ref NegaFibbonachi, inputNumber);
// for (int i = 2; i < Fibbonachi.Length; i++)
// {
//     Fibbonachi[i] = Fibbonachi[i-1]+ Fibbonachi[i-2];
// }
// for (int i = 2; i < NegaFibbonachi.Length; i++)
// {
//     NegaFibbonachi[i] = NegaFibbonachi[i-2]- NegaFibbonachi[i-1];
// }
// Array.Reverse(NegaFibbonachi);
// Console.WriteLine($"С числом {inputNumber} НегаФиббоначи получается - ");
// ArrayOutput(NegaFibbonachi);
// ArrayOutput(Fibbonachi);

// void ArrayOutput(int[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         Console.Write($"{massiv[i]} ");
//     }
// }