// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 
// и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа 
// результат переводим в двоичную систему счисления.

Console.Clear();
Console.WriteLine("Задача с очень длинным описанием (доп задача со звёздочкой)");
int size = 0;
Random rnd = new Random();
List<int> array1 = new List<int>();
List<int> array2 = new List<int>();
double sum = 0.0;

while(true) {
Console.WriteLine("\nНапишите - из скольки элементов должны состоять одномерные массивы? : ");
if(int.TryParse(Console.ReadLine(), out size)) {
    if(size > 1) {
        break;
    } else Console.WriteLine("Некорректно указано количество элементов массивов!\n");
} else Console.WriteLine("Некорректно указано количество элементов массивов!\n");
}

for(int index = 0; index < size; index++) {
    array1.Add(rnd.Next(1, 10));
    array2.Add(rnd.Next(1, 10));
}

Console.WriteLine("\nСреднее арифметическое первого массива ");
CalcAndPrint(array1);
Console.WriteLine(" = " + sum / Convert.ToDouble(size));
double average1 = sum / Convert.ToDouble(size);
Console.WriteLine("\nСреднее арифметическое второго массива ");
CalcAndPrint(array2);
Console.WriteLine(" = " + sum / Convert.ToDouble(size));
double average2 = sum / Convert.ToDouble(size);


int result = Math.Abs((int) Math.Round(average1 - average2));
Console.WriteLine("\nРазница между средними арифметическими заданных массивов = " + result);
Console.WriteLine("\nЧисло " + result + " в двоичной системе исчисления = " + Convert.ToString(result, 2));


void CalcAndPrint(List<int> array) {
    sum = 0.0;
    for(int index = 0; index < size; index++) {
        sum += Convert.ToDouble(array[index]);
        if(index == 0) {
            Console.Write("[" + array[index] + ", ");
        } else if(index == size - 1) {
            Console.Write(array[size - 1] + "]");
        } else Console.Write(array[index] + ", ");
    }
}