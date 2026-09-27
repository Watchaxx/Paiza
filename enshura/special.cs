// Test case 3 が TLE で失敗
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int blank = -1;
        int idx = 0;
        int[] board = new int[16];

        foreach( int _ in Range( 0, 4 ) ) {
            string[] t = Console.ReadLine().Split();

            foreach( string s in t ) {
                if( int.TryParse( s, out int i ) == true ) {
                    board[idx] = i;
                } else {
                    blank = idx;
                    board[idx] = 0;
                }
                idx++;
            }
        }

        int dist = Manhattan( board );
        var path = new List<int>();

        while( true ) {
            int t = Search( blank, dist, 0, -1, board, path );

            if( t == 0 ) {
                break;
            }
            dist = t;
        }
        Console.WriteLine( string.Join( Environment.NewLine, path ) );
        return;
    }

    static int Manhattan( int[] board )
    {
        int d = 0;

        foreach( int i in Range( 0, 16 ) ) {
            int v = board[i];

            if( v != 0 ) {
                int tx = ( v - 1 ) % 4;
                int ty = ( v - 1 ) / 4;
                int cx = i % 4;
                int cy = i / 4;

                d += Math.Abs( tx - cx ) + Math.Abs( ty - cy );
            }
        }
        return d;
    }

    static int Search( int blank, int dist, int g, int pre, int[] board, List<int> path )
    {
        int d = Manhattan( board );
        int f = d + g;

        if( dist < f ) {
            return f;
        } else if( d == 0 ) {
            return 0;
        }

        int m = int.MaxValue;
        int x = blank % 4;
        int y = blank / 4;
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        int[] op = { 1, 0, 3, 2 };

        foreach( int i in Range( 0, 4 ) ) {
            int nx = x + dx[i];
            int ny = y + dy[i];

            if( pre != -1 && i == op[pre] ) {
                continue;
            }
            if( nx < 0 || 4 <= nx || ny < 0 || 4 <= ny ) {
                continue;
            }

            int nb = nx + 4 * ny;
            int mv = board[nb];

            board[blank] = mv;
            board[nb] = 0;
            path.Add( mv );

            int t = Search( nb, dist, g + 1, i, board, path );

            if( t == 0 ) {
                return 0;
            } else if( t < m ) {
                m = t;
            }
            board[blank] = 0;
            board[nb] = mv;
            path.RemoveAt( path.Count - 1 );
        }
        return m;
    }
}
