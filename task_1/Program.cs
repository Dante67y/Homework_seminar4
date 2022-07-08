// Напишите цикл, который принимает на вход два числа "A" и "B" и возводит число "A" в натуральную степень "B"

Console.Write("Введите 1-е число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int y = Convert.ToInt32(Console.ReadLine());
//int z = x, i = 1;
//while (i < y){
//    i++;
int z = x;
for (int i = 1; i < y; i++){
    z = z * x;
}
Console.WriteLine(z);
