// 実行時間 80ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    const int bLen = 100;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[] bc = new int[n[0] / bLen + 1];
        int[] bm = Repeat( int.MaxValue, n[0] / bLen + 1 ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, n[0] / bLen + 1 ) ) {
            Update( n[0], i, a, bm );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            t[1]--;
            t[2]--;
            if( t[0] == 0 ) {
                int o = int.MaxValue;

                Eval( n[0], t[1] / bLen, a, bc );
                Eval( n[0], t[2] / bLen, a, bc );
                Update( n[0], t[1] / bLen, a, bm );
                Update( n[0], t[2] / bLen, a, bm );
                if( t[1] / bLen != t[2] / bLen ) {
                    for( int i = t[1] / bLen + 1; i < t[2] / bLen; i++ ) {
                        o = Min( o, bm[i] );
                    }
                    for( int i = t[1]; i < t[1] + bLen - t[1] % bLen; i++ ) {
                        o = Min( o, a[i] );
                    }
                    for( int i = t[2] - t[2] % bLen; i <= t[2]; i++ ) {
                        o = Min( o, a[i] );
                    }
                } else {
                    for( int i = t[1]; i <= t[2]; i++ ) {
                        o = Min( o, a[i] );
                    }
                }
                WriteLine( o );
            } else if( t[0] == 1 ) {
                Eval( n[0], t[1] / bLen, a, bc );
                a[t[1]] = t[2] + 1;
                Update( n[0], t[1] / bLen, a, bm );
            } else if( t[0] == 2 ) {
                if( t[1] / bLen != t[2] / bLen ) {
                    for( int i = t[1] / bLen + 1; i < t[2] / bLen; i++ ) {
                        bc[i] += t[3];
                        bm[i] += t[3];
                    }
                    Eval( n[0], t[1] / bLen, a, bc );
                    Eval( n[0], t[2] / bLen, a, bc );
                    for( int i = t[1]; i < t[1] + bLen - t[1] % bLen; i++ ) {
                        a[i] += t[3];
                    }
                    for( int i = t[2] - t[2] % bLen; i <= t[2]; i++ ) {
                        a[i] += t[3];
                    }
                    Update( n[0], t[1] / bLen, a, bm );
                    Update( n[0], t[2] / bLen, a, bm );
                } else {
                    Eval( n[0], t[1] / bLen, a, bc );
                    for( int i = t[1]; i <= t[2]; i++ ) {
                        a[i] += t[3];
                    }
                    Update( n[0], t[1] / bLen, a, bm );
                }
            }
        }
        Out.Flush();
        return;
    }

    static void Eval( int n, int bi, int[] a, int[] bc )
    {
        foreach( int i in Range( 0, bLen ) ) {
            int j = bLen * bi + i;

            if( n - 1 < j ) {
                break;
            }
            a[j] += bc[bi];
        }
        bc[bi] = 0;
        return;
    }

    static void Update( int n, int bi, int[] a, int[] bm )
    {
        bm[bi] = int.MaxValue;
        foreach( int i in Range( 0, bLen ) ) {
            int j = bLen * bi + i;

            if( n - 1 < j ) {
                break;
            }
            bm[bi] = Min( bm[bi], a[j] );
        }
        return;
    }
}
