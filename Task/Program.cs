
string[] UserArray(int size)
{

    string[] arr = new string[size];
       for (int i = 0; i < size; i++)
     {
      Console.WriteLine($"Введите элемент массива под индексом {i}");
      arr[i] = Console.ReadLine();

     }
     return arr;

}

Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    
    string[] array = UserArray(size);
Console.WriteLine("Вывод массива заданного пользователем: ");
Console.WriteLine(String.Join (", ", array));

string[] arr2 = new string[size];
for (int i = 0; i < size; i++)
{
    if (array[i].Length<4)
    {
        arr2[i]=array[i];
    }
    Console.Write(arr2[i] + " ");
}
