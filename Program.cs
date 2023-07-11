// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, 
// если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 
// должны быть расположены в разных коммитах)


//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string [] FillArray(int size)
{
    string[] array = new string[size];
    for (int i=0; i < array.Length; i++)
    {
        Console.WriteLine("Input the element of the array");
        array[i] = Console.ReadLine();
    }
    return array;
}

int QuantityElementsToPrint(string[] array)
{
    int count = 0;
    for(int i=0; i < array.Length;i++)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
           count++;
        }
    }
    return count;
}

void NewArr (string[]array, string[] newArray)
{
int n = 0;
for (int j = 0; j < array.Length; j++)
{
    int length = array[j].Length;
    if (length <= 3)
    {
        newArray[n] = array[j];
        n++;
    }
}      
    
Console.WriteLine($"[{string.Join(",",newArray)}]");
}


Console.WriteLine("Input the array size");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = FillArray(size);
Console.WriteLine($"[{string.Join(",",array)}]");

string[] newArray = new string [QuantityElementsToPrint(array)];

NewArr(array, newArray);