//Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
Console.Write($"{n} -> ");
if (n > 99) {
    Console.WriteLine(number[2]);
} else {
    Console.WriteLine("третьей цифры нет");
}