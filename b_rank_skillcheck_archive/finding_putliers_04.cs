// 実行時間 20ms
using System.Linq;
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        ReadLine();
        decimal[] p1 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal[] p2 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal[] p3 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal a = p2[1] - p1[1];
        decimal b = ( p2[0] - p1[0] ) * -1;
        decimal c = ( p2[0] - p1[0] ) * p1[1] - a * p1[0];
        WriteLine( Abs( a * p3[0] + b * p3[1] + c ) / (decimal)Sqrt( (double)( a * a + b * b ) ) );
        return;
    }
}
