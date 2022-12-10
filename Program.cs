string[] GetFillArray(int arrayLen)
{
    string [] resultArray = new string [arrayLen];
    for (int i=0; i<resultArray.Length; i++)
    {
       Console.WriteLine ("Введите строку "+i);
       resultArray[i] = Console.ReadLine(); 
    }
        
    return resultArray;
}

void PrintArray (string[] inArray)
{
string st = "[]";
if (inArray.GetLength(0) > 0)
     {
      st = "[\"";
        for (int i=0; i<inArray.Length; i++)
           st+= inArray[i]+ "\", \"";
       
     st = st.Substring(0, st.Length - 3) + "]";
     } 
    Console.WriteLine (st);
  }

Console.WriteLine ("Введите количество строк");
int amount = int.Parse(Console.ReadLine());
string [] inArray = GetFillArray (amount);
PrintArray(inArray);
