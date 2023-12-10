//6.1 Сред

//double[] realNumbers = new double[] { 3.1, 4.7, -5.8, 2.6, -3.2, 6.9, -2.2 };


//int[] integers = realNumbers.Select(r => MyRound(r)).ToArray();

//int maxModulo = MaxModulo(integers);

//Console.WriteLine("Rounded integers:");
//foreach (int num in integers)
//{
//    Console.Write(num + " ");
//}
//Console.WriteLine("\nMaximum modulo number: " + maxModulo);
//static int MyRound(double number)
//{
//    if (number < 0)   
//        return Convert.ToInt32(Math.Ceiling(number - 0.5));
//    else
//        return Convert.ToInt32(Math.Floor(number + 0.5));
//}


//static int MaxModulo(int[] numbers)
//{
//    return numbers.Select(x => Math.Abs(x)).Max();
//}