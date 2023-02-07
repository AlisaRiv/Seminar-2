//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
//является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int dayofweek = Convert.ToInt32(Console.ReadLine());
if (dayofweek > 0 && dayofweek < 8) {
    Console.Write($"{dayofweek} -> ");
    if (dayofweek == 6 || dayofweek == 7) {
        Console.WriteLine("да");
    } else {
        Console.WriteLine("нет");
    }
} else {
    Console.WriteLine("Необходимо ввести число от 1 до 7");
}

