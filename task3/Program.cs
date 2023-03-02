//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//* при N < 0, нужно вывести от N до -1
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int masiv = N;
if (N < 0){
    i = N;
    masiv = -N;
    N = -1;}
int[] result = new int[masiv];
for ( int j = 0; i<=N ; i++){
    result[j] = i * i * i;
    j++;
}
for (int j = 0; j < masiv; j++){
    Console.WriteLine($"{result[j]}" );
}