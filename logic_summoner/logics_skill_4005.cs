using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static int H = 0;
    static int W = 0;
    static int[,] Chk = new int[50, 50];

    enum Stat { False, True, All }

    static void Main()
    {
        int[] whn = ReadLine().Split().Select( int.Parse ).ToArray();
        char[][] s = new char[whn[1]][];
        var l = new List<string>();

        H = whn[1];
        W = whn[0];
        foreach( int i in Range( 0, whn[1] ) ) {
            s[i] = ReadLine().ToCharArray();
        }
        foreach( int _ in Range( 0, whn[2] ) ) {
            foreach( int i in Range( 0, 50 ) ) {
                foreach( int j in Range( 0, 50 ) ) {
                    Chk[i, j] = -1;
                }
            }

            var t = Find( s );
            int x = t.Item1;
            int y = t.Item2;
            object u = Update( x, y, s );

            if( u is Stat && (Stat)u == Stat.All ) {
                break;
            } else if( !( u is Stat && (Stat)u == Stat.False ) ) {
                s = (char[][])u;
                l.Add( $"{x + 1} {y + 1}" );
            }
        }
        WriteLine( l.Count );
        WriteLine( string.Join( System.Environment.NewLine, l ) );
        return;
    }

    static (int, int) Find( char[][] m )
    {
        int s = -1;
        int x = 0;
        int y = 0;

        foreach( int i in Range( 0, m.Length ).Reverse() ) {
            foreach( int j in Range( 0, m[0].Length ).Reverse() ) {
                if( m[i][j] != '-' && Chk[i, j] == -1 ) {
                    int t = GetSize( j, i, m );

                    if( s < t ) {
                        s = t;
                        x = j;
                        y = i;
                    }
                }
            }
        }
        return (x, y);
    }

    static int GetSize( int x, int y, char[][] m )
    {
        char rgb = m[y][x];
        int cnt = 1;
        var d = new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
        var s = new Stack<(int, int)>();

        s.Push( (y, x) );
        Chk[y, x] = 1;
        while( 0 < s.Count ) {
            var t = s.Pop();

            foreach( var p in d ) {
                int nx = t.Item2 + p.Item2;
                int ny = t.Item1 + p.Item1;

                if( IsInside( ny, nx ) != true ) {
                    continue;
                }
                if( m[ny][nx] == rgb && Chk[ny, nx] == -1 ) {
                    Chk[ny, nx] = 1;
                    cnt++;
                    s.Push( (ny, nx) );
                }
            }
        }
        return cnt;
    }

    static bool IsInside( int y, int x )
    {
        return 0 <= y && y < H && 0 <= x && x < W;
    }

    static object Update( int x, int y, char[][] m )
    {
        bool b = true;
        char rgb = m[y][x];

        foreach( char[] r in m ) {
            foreach( char c in r.Where( z => z != '-' ) ) {
                b = false;
                break;
            }
            if( b != true ) {
                break;
            }
        }
        if( b == true ) {
            return Stat.All;
        } else if( rgb == '-' ) {
            return Stat.False;
        }

        var d = new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
        var s = new Stack<(int, int)>();

        s.Push( (y, x) );
        while( 0 < s.Count ) {
            var t = s.Pop();

            m[t.Item1][t.Item2] = '-';
            foreach( var p in d ) {
                int nx = t.Item2 + p.Item2;
                int ny = t.Item1 + p.Item1;

                if( IsInside( ny, nx ) != true ) {
                    continue;
                }
                if( m[ny][nx] == rgb ) {
                    m[ny][nx] = '-';
                    s.Push( (ny, nx) );
                }
            }
        }
        foreach( int i in Range( 0, W ) ) {
            var l = new List<char>( H );

            foreach( int j in Range( 0, H ).Where( z => m[z][i] != '-' ) ) {
                l.Add( m[j][i] );
            }
            if( l.Count <= H ) {
                var c = Repeat( '-', H - l.Count ).ToList();

                c.AddRange( l );
                foreach( int j in Range( 0, H ) ) {
                    m[j][i] = c[j];
                }
            }
        }
        return m;
    }
}
