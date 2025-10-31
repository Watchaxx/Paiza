// 実行時間 20ms
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        double m = double.Parse( ReadLine() ) / 180d * PI;
        double x = double.Parse( ReadLine() );
        double y = double.Parse( ReadLine() );
        double c = Round( Cos( m ), 15 );
        double s = Round( Sin( m ), 15 );

        WriteLine( x * c - y * s );
        WriteLine( x * s + y * c );
        return;
    }
}
