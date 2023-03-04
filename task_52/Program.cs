/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = Convert.ToInt32(ReadInput);
  return result;

}
void FillMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
      matr[i, j] = new Random().Next(0, 99);
  }
}
void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    Console.Write(matr[i, j] + "\t  ");
    Console.WriteLine();
  }
}
void MeanOfColumn(int[,] matr, int m)
{
  for (int j = 0; j < matr.GetLength(1); j++)
  {
    double meanOfColumn = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      meanOfColumn = (meanOfColumn + matr[i, j]);
    }
    meanOfColumn = meanOfColumn / m;
    Console.Write(meanOfColumn.ToString("F2") + "\t  ");
  }
}
int m = Prompt("Введите количество строк матрицы:  ");
int n = Prompt("Введите количество столбцов матрицы:  ");
int[,] matr = new int[m, n];
FillMatrix(matr);
PrintMatrix(matr);
MeanOfColumn(matr, m);
