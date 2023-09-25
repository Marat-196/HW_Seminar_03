// double Distance(int xValue1, int xValue2, int yValue1, int yValue2)
// {
//     double result = Math.Sqrt(Math.Pow((xValue2 - xValue1), 2) + Math.Pow((yValue2 - yValue1), 2));
//     return result;
//return Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2));
using System;

double DistanceBetweenPoints(int[] pointA, int[] pointB)
{
    return Math.Round(Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2)),2);

}

int[] sp = {7,-5, 0};
int[] sp_new = {1,-1,9};

// Console.WriteLine($"{Math.Round(DistanceBetweenPoints(sp, sp_new), 2)}");
Console.WriteLine($"{DistanceBetweenPoints(sp, sp_new)}");