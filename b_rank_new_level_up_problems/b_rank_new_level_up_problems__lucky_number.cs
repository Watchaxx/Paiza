// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1000000;
        int[] d = { 0, 1, -1 };
        int[] x = new int[n];

        foreach( int i in Range( 0, n ) ) {
            x[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, n ) ) {
            for( int j = i + 1; j < n; j++ ) {
                foreach( int k in Range( 0, 5 ) ) {
                    foreach( int l in Range( 0, 5 ) ) {
                        int n1 = 0;
                        int n2 = 0;

                        switch( k ) {
                        case 3:
                            n1 = int.Parse( $"1{x[i]}" );
                            break;
                        case 4:
                            n1 = int.Parse( $"{x[i]}1" );
                            break;
                        default:
                            n1 = x[i] + d[k];
                            break;
                        }
                        switch( l ) {
                        case 3:
                            n2 = int.Parse( $"1{x[j]}" );
                            break;
                        case 4:
                            n2 = int.Parse( $"{x[j]}1" );
                            break;
                        default:
                            n2 = x[j] + d[l];
                            break;
                        }
                        o = Min( o, Abs( n1 - n2 ) );
                    }
                }
            }
        }
        WriteLine( o );
        return;
    }
}
