int numberA = new Random().Next(1, 10);//1 2 3 4 5 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
//решение без переменной result - Console.Write(numberA + numberB);
int result = numberA + numberB;
Console.WriteLine(result); // Решение с переменной result

