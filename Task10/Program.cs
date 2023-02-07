//Напишите программу, которая принимает на вход трёхзначное число
 //и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
if (n > 99 && n < 1000) {
    Console.WriteLine($"{n} -> {number[1]}");
} else {
    Console.WriteLine("Необходимо ввести трехзначное число.");
}
