// Создаём массив строк(вводимых с клавиатуры)

string[] startArray = new string[7];
for (int i = 0; i < startArray.Length; i++)
    {
        Console.WriteLine("Введите данные" + i);
        startArray[i] = Console.ReadLine();
    }

// Сортируем массив в которых входят не более 3-ёх элементов

int finalArraySize = 0;

for (int i = 0; i < startArray.Length; i++)
    {
    if (startArray[i].Length <= 3)
        {
            finalArraySize++;
        }
    }
// Cоздаём новый массив и копируем все элементы длиной менее 3-ёх символов

string[] finalArray = new string[finalArraySize];
int finalArrayIndex = 0;

for (int i = 0; i < startArray.Length; i++)
    {    
    if (startArray[i].Length <= 3)
        {
            finalArray[finalArrayIndex++] = startArray[i];
        }
    }

Console.WriteLine("Начальный массив: ");
for (int i = 0; i < startArray.Length; i++)
    {
        Console.Write(startArray[i] + ((i != startArray.Length - 1) ? ", ": ""));
    }
    Console.WriteLine();

    Console.Write("Итоговый массив: ");
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write(finalArray[i] + ((i != finalArray.Length - 1) ? ", " : ""));
    }