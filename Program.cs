// Console.Write("Введите числа через пробел: ");
// int[] numbers = StringToNum(Console.ReadLine()!);
// Console.WriteLine();
// Console.WriteLine($"Количество значений больше 0 = {Positive(numbers)}");


// int[] StringToNum(string stringArray){
//     string[]nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[]result = new int[nums.Length];
//     for (int i = 0; i < nums.Length; i++){
//         result[i] = int.Parse(nums[i]);
//     }
//     return result;
// }
// int Positive(int[] array){
//     int count = 0;
//     foreach (var item in array){
//         if(item > 0) count++;
//     }
//     return count;
// }

// Написать программу, которая на вход принимает массив из любого количества элементов 
//(не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив,
//но отсортированный по возрастанию(от меньшего числа к большему).

int[] array = CreateArray(10);
Console.WriteLine($"[{String.Join(", ", array)} ]");
SortArray(array);
Console.WriteLine($"[{String.Join(", ", array)} ]");

int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void SortArray(int[] array){
    for (int i=0; i<array.Length; i++){
        for (int j=i+1; j<array.Length; j++){
            if (array[i] > array[j]){
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}