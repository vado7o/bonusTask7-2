// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 
// и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа 
// результат переводим в двоичную систему счисления.

Console.Clear();
Console.WriteLine("Задача с очень длинным описанием (доп задача со звёздочкой)");
int size = 0;
int size2 = 0;
Random rnd = new Random();
List<int> array1 = new List<int>();
List<int> array2 = new List<int>();
double sum = 0.0;
double average1 = 0.0;
double average2 = 0.0;

SelectSize(1);
SelectSize(2);

FillArray(size, array1);
FillArray(size2, array2);

CalcAverage(1, array1, size);
CalcAverage(2, array2, size2);

int result = Math.Abs((int) Math.Round(average1 - average2));
Console.WriteLine("\nРазница между средними арифметическими заданных массивов = " + result);
Console.WriteLine("\nЧисло " + result + " в двоичной системе исчисления = " + Convert.ToString(result, 2));


void CalcAndPrint(List<int> array, int size) {
    sum = 0.0;
    for(int index = 0; index < size; index++) {
        sum += Convert.ToDouble(array[index]);
        if(index == 0) {
            Console.Write("\n[" + array[index] + ", ");
        } else if(index == size - 1) {
            Console.Write(array[size - 1] + "]");
        } else Console.Write(array[index] + ", ");
    }
}

void SelectSize(int variant) {
while(true) {
    Console.Write("\nНапишите - из скольки элементов должен состоять следующий массив? : ");
    if(int.TryParse(Console.ReadLine(), out int number)) {
        if(number > 1) {
            if(variant == 1) {
                size = number;
            } else { size2 = number; }    
        break;
        } else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
    } else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
}
}

void FillArray(int size, List<int> array) {
for(int index = 0; index < size; index++) {
    array.Add(rnd.Next(1, 10));
}
}

void CalcAverage(int variant, List<int> array, int size) {
CalcAndPrint(array, size);
if(variant == 1) {
    Console.WriteLine("\nСреднее арифметическое первого массива ");
    average1 = sum / Convert.ToDouble(size);
} else {
    Console.WriteLine("\nСреднее арифметическое второго массива ");
    average2 = sum / Convert.ToDouble(size);
}
Console.WriteLine(" = " + sum / Convert.ToDouble(size));
}