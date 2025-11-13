// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int x = int.Parse( ReadLine() );
        int[] v = new int[4];
        int[] w = new int[4];

        foreach( int i in Range( 0, 4 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            w[i] = t[0];
            v[i] = t[1];
        }
        foreach( int i in Range( 0, 2 ) ) {
            foreach( int j in Range( 0, 2 ) ) {
                foreach( int k in Range( 0, 2 ) ) {
                    foreach( int l in Range( 0, 2 ) ) {
                        int sv = 0;
                        int sw = 0;

                        if( 0 < i ) {
                            sv += v[0];
                            sw += w[0];
                        }
                        if( 0 < j ) {
                            sv += v[1];
                            sw += w[1];
                        }
                        if( 0 < k ) {
                            sv += v[2];
                            sw += w[2];
                        }
                        if( 0 < l ) {
                            sv += v[3];
                            sw += w[3];
                        }
                        if( sw <= x ) {
                            o = System.Math.Max( o, sv );
                        }
                    }
                }
            }
        }
        WriteLine( o );
        return;
    }
}
