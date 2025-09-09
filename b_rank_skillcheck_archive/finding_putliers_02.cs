// 実行時間 20ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        decimal[] p1 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal[] p2 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        WriteLine( $"{p2[1] - p1[1]} {( p2[0] - p1[0] ) * -1} {( p2[0] - p1[0] ) * p1[1] - ( p2[1] - p1[1] ) * p1[0]}" );
        return;
    }
}
