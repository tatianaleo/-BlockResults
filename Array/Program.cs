// Из имеющегося массива строк сформировать новый массив из строк,
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string [] array = {"I","84124","computer","def",".","hello","maxi","lik","e","85623","it"};
string[] newarray = new string [0];    //создаем пустой массив


for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            Array.Resize(ref newarray, newarray.Length + 1); //увеличиваем размер на 1 
            newarray[newarray.Length - 1] = array[i]; // добавляем в конец нашего массива нужный элемент
        }
    }
Console.WriteLine("New array: ");
 for (int i = 0; i < newarray.Length; i++)
    {
    Console.WriteLine(newarray[i]);
    }
    // Выведем массив в одну строку:
    string joinedArray = string.Join(" ", newarray); // объединяем элементы массива с запятой и пробелом
    Console.WriteLine("New array: {{{0}}}", joinedArray);