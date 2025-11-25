// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var d = new System.DateTime( 2025, 11, 25, 1, 0, 0 );

        foreach( int _ in Range( 0, n ) ) {
            var e = d.AddMinutes( int.Parse( ReadLine() ) / -3 );

            WriteLine( $"{Pad( e.Hour )}:{Pad( e.Minute )}" );
        }
        return;
    }

    static string Pad( int i )
    {
        return i < 10 ? $"0{i}" : $"{i}";
    }
}
