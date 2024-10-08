﻿// See https://aka.ms/new-console-template for more information
using Algorithms;

//Console.Write("Solution Factorial Problem => Itrative Way : ");
//Console.WriteLine(FactorialProblem.factorial(4));
//Console.WriteLine();
//Console.Write("Solution Factorial Problem  => Recursive Way : ");
//Console.WriteLine(FactorialProblem.factorial2(5));

//Console.WriteLine();
//Console.Write("Solution Fibonacci sequence => Recursive Way : ");
//Console.WriteLine(FibonacciSequence.Fibonacci(34));
//Console.WriteLine();
//Console.Write("Solution Fibonacci with cache => Recursive Way : ");
//Console.WriteLine(RecursionProblems.Fibonacci(10));


//Console.WriteLine();
//Console.WriteLine("Solution Bubble Sort Algorithms : ");
//int[] array = [5, 4, 2, 8, 9, 7, 1, 3, 6];
//foreach (var item in array)
//{
//    Console.Write(item + " ");
//}
//var newarray = BubbleSort.BubbleSorts(array);

//Console.WriteLine();
//foreach (var item in newarray)
//{
//    Console.Write(item + " ");
//}


//Console.WriteLine();
//Console.WriteLine("Solution Selection Sort Algorithms : ");
//int[] selectSort = {5, 4, 2, 8, 9, 7, 1, 3, 6, 11, 15, 12, 13};
//foreach (var item in selectSort)
//{
//    Console.Write(item + " ");
//}
//var newSelectSort = SelectionSorts.SelectionSort(selectSort);

//Console.WriteLine();
//foreach (var item in newSelectSort)
//{
//    Console.Write(item + " ");
//}


//Console.WriteLine();
//Console.WriteLine("Solution Insertion Sort Algorithms : ");
//int[] insertSort = { 8, 5, 2, 9, 5, 6, 3 };
//foreach (var item in insertSort)
//{
//    Console.Write(item + " ");
//}
//var newInsertSort = InsertionSort.InsertionSorts(insertSort);

//Console.WriteLine();
//foreach (var item in newInsertSort)
//{
//    Console.Write(item + " ");
//}


Console.WriteLine();
Console.WriteLine("Solution Merge Sort Algorithms => Divide and Conquer : ");
int[] mergeSort = { 8, 5, 2, 7, 9, 5, 6, 4, 3 };
foreach (var item in mergeSort)
{
    Console.Write(item + " ");
}
var newMergeSort = MergeSorting.MergeSort(mergeSort);

Console.WriteLine();
foreach (var item in newMergeSort)
{
    Console.Write(item + " ");
}


Console.WriteLine();
Console.WriteLine("Solution Quick Sort Algorithms => Divide and Conquer : ");
int[] quickSort = { 8, 5, 2, 9, 5, 6, 3 };
int[] newQuickSort = { 8762, 654, 3008, 345, 87, 65, 234, 14, 2, 7 };
foreach (var item in quickSort)
{
    Console.Write(item + " ");
}
var newQuickSort2 = QuickSorting.QuickSort(newQuickSort);

Console.WriteLine();
foreach (var item in newQuickSort2)
{
    Console.Write(item + " ");
}



Console.WriteLine();
Console.WriteLine("Solution Radix Sort Algorithms => Divide and Conquer : ");
int[] radixSort = { 8, 5, 2, 9, 5, 6, 3, 9 };
int[] newRadixSort = { 8762, 654, 3008, 345, 87, 65, 234, 14, 2, 7 };
foreach (var item in radixSort)
{
    Console.Write(item + " ");
}
var newRadixSort2 = QuickSorting.QuickSort(newRadixSort);

Console.WriteLine();
foreach (var item in newRadixSort2)
{
    Console.Write(item + " ");
}

