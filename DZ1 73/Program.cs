int number = Input("Введите число N: ");

int[] tempArray = CreateArray(number);
AddRows(tempArray);

void AddRows(int[] array)
{
  int[] arrayTemp = new int[array.Length];
  int rows = 1;
  int count = 0;
  int numberOne = 0;
  int numberTwo = 0;
  int switchTemp = 0;
  
  for (int i = 0; i < array.Length; i++)
  {
    Array.Clear(arrayTemp);
    count = 0;
    if (array[i] != 0)
    {
      arrayTemp[count] = array[i];
      numberTwo = array[i];
      for (int j = i; j < array.Length; j++)
      {
        if (array[j] % numberTwo != 0 || array[j] / numberTwo == 1)
        {
          switchTemp = 0;
          numberOne = array[j];
          for (int k = 0; k < count; k++)
            if (numberOne % arrayTemp[k] == 0) 
              switchTemp++;
          if (switchTemp == 0)
          {
            arrayTemp[count] = array[j];
            count++;
            array[j] = 0;
          }
        }
      }
      Console.WriteLine($"Группа {rows++}: {PrintArray(arrayTemp)}");
    }
  }
}

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[] CreateArray(int n)
{
  int[] temp = new int[n];
  for (int i = 0; i < temp.GetLength(0); i++)
    temp[i] = i + 1;
  return temp;
}

string PrintArray(int[] array)
{
  string result = "";
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] != 0) 
      result += $"{array[i],1} ";
  }
  return result;
}