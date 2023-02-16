// Задайте одномерный массив из 123 случайных чисел [0: 1000].
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5

Console.Clear();


int[] numbers = new int[123];
FillArray(numbers, 0, 1000);

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int count = 0;
for(int i = 0; i<numbers.Length; i++ )
{
  if (numbers[i]>=10 && numbers[i]<100)
    {
      count += 1;
    }
   }

WriteArray(numbers);
Console.WriteLine();

Console.WriteLine($"Число элементов от 10 до 99: {count} ");