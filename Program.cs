string[] GetFillArray(int arrayLen) //Ввод строк массива
{
    string [] resultArray = new string [arrayLen];
    for (int i=0; i<resultArray.Length; i++)
    {
       Console.WriteLine ("Введите строку "+i);
       resultArray[i] = Console.ReadLine(); 
    }
    return resultArray;
}

string[] CheckAndCopy (string[]inArray) //Основной метод программы
{
    string[] result = new string[(inArray.GetLength(0))];
    int count=0;
    for (int i=0; i<inArray.Length; i++)
        {
        
        if (inArray[i].Length<=3)
            {
                result[count]=inArray[i];
                count++;
            }
        }
    Array.Resize(ref result, (count)); //удаляем пустые элементы массива если такие есть
    return result;
}

void PrintArray (string[] inArray) //Вывод в консоль массива
{
string st = "[]";
if (inArray.GetLength(0) > 0)
     {
      st = "[\"";
        for (int i=0; i<inArray.Length; i++)
           st+= inArray[i]+ "\", \"";       
     st = st.Substring(0, st.Length - 3) + "]"; // подрезаем запятую и пробел
     } 
     Console.Write (st);
  }

Console.Clear();
int amount=0;
while(amount==0)
{
    try
    {
        Console.WriteLine ("Введите количество строк");
        amount = int.Parse(Console.ReadLine());
        break;
    }
    catch
    {
            Console.WriteLine ("Ошибка! Вы ввели не число."); //обрабатываем исключение
    }
}
string [] inArray = GetFillArray (amount);
string [] outArray = CheckAndCopy(inArray);
PrintArray(inArray);
Console.Write (" -> ");
PrintArray(outArray);
Console.WriteLine();

