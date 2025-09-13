// 実行時間 10ms
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        string[] rl = ReadLine().Split( ' ' );
        long a = long.Parse( rl[0] );
        long b = long.Parse( rl[1] );
        long c = long.Parse( rl[3] );
        long d = long.Parse( rl[4] );
        long ch = 0;
        long mo = 0;

        switch( rl[2] ) {
        case "+":
            ch = a * d + b * c;
            mo = b * d;
            break;
        case "-":
            ch = a * d - b * c;
            mo = b * d;
            break;
        case "*":
            ch = a * c;
            mo = b * d;
            break;
        case "/":
            ch = a * d;
            mo = b * c;
            break;
        }
        if( mo < 0 ) {
            ch *= -1;
            mo *= -1;
        }

        long sho = Gcd( Abs( ch ), Abs( mo ) );

        WriteLine( $"{ch / sho} {mo / sho}" );
        return;
    }

    static long Gcd( long a, long b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
