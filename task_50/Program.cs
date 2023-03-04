//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

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
void MatrValue(int[,] matr, int a, int b, int m, int n)
{
if (a > m || b > n)
  Console.WriteLine("такого элемента в матрице нет");
else
{
  int matrValue = matr[a, b];
  Console.WriteLine("значение элемента на данной позиции равно: " + matrValue);
}
}
int m = Prompt("Введите количество строк матрицы:  ");
int n = Prompt("Введите количество столбцов матрицы:  ");
int a = Prompt("Введите номер строки:  ");
int b = Prompt("Введите номер столбца:  ");
int[,] matr = new int[m, n];
FillMatrix(matr);
PrintMatrix(matr);
MatrValue(matr,a,b,m,n);

