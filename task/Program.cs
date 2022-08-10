string[] inputArray = { "day", "trunk", "engine", "Hi", "car", "#%1", "_!/", "56" };
int count = 0; // Длина результирующего массива
int index = 0; // Индекс первого элемента результирующего массива

/// Ищем элементы удовлятворяющие условию задачи и выводим массив
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3) count++; 
}
Console.Write($"Initial array is [{String.Join(", ", inputArray)}]\n");

string[] finalArray = new string[count]; // Объявляем результирующий массив и заполняем его

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        finalArray[index] = inputArray[i];
        index++;
    }
    if (index == count) break;
}
Console.WriteLine($"Output array is: [{String.Join(", ", finalArray)}]");