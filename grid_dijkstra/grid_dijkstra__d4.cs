// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    class PQueue<T> where T : System.IComparable<T>
    {
        List<T> h = new List<T>();
        internal int Count => h.Count;

        internal T Deq()
        {
            int c = h.Count - 1;
            int i = 0;
            T ret = h[0];

            h[0] = h[c];
            h.RemoveAt( c );
            while( true ) {
                int l = 2 * i + 1;

                if( h.Count <= l ) {
                    break;
                }

                int r = l + 1;
                int m = r < h.Count && h[r].CompareTo( h[l] ) < 0 ? r : l;

                if( h[i].CompareTo( h[m] ) <= 0 ) {
                    break;
                }
                Swap( h, i, m );
                i = m;
            }
            return ret;
        }

        internal void Enq( T i )
        {
            int c = h.Count - 1;

            h.Add( i );
            while( 0 < c ) {
                int p = ( c - 1 ) >> 1;

                if( h[p].CompareTo( h[c] ) <= 0 ) {
                    break;
                }
                Swap( h, c, p );
                c = p;
            }
            return;
        }

        private void Swap( List<T> a, int x, int y )
        {
            T t = a[x];
            a[x] = a[y];
            a[y] = t;
            return;
        }
    }

    class Stat : System.IComparable<Stat>
    {
        internal int Cst;
        internal int X;
        internal int Y;
        internal int Tkt;

        internal Stat( int x, int y, int c, int t )
        {
            Cst = c;
            X = x;
            Y = y;
            Tkt = t;
        }

        public int CompareTo( Stat s )
        {
            return Cst - s.Cst;
        }

        public override bool Equals( object o )
        {
            Stat s = (Stat)o;
            return s != null && X == s.X && Y == s.Y && Tkt == s.Tkt;
        }

        public override int GetHashCode()
        {
            return ( X << 16 ) | Y;
        }
    }

    static void Main()
    {
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] t = new int[hw[0]][];
        var s = new HashSet<Stat>();
        var q = new PQueue<Stat>();

        foreach( int i in Range( 0, hw[0] ) ) {
            t[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        q.Enq( new Stat( 0, 0, t[0][0], int.Parse( ReadLine() ) ) );
        while( 0 < q.Count ) {
            Stat p = q.Deq();

            if( p.X == hw[1] - 1 && p.Y == hw[0] - 1 ) {
                WriteLine( p.Cst );
                break;
            }
            if( s.Contains( p ) == true ) {
                continue;
            }
            s.Add( p );
            foreach( int i in Range( 0, 4 ) ) {
                int x = p.X + dx[i];
                int y = p.Y + dy[i];

                if( 0 <= x && x < hw[1] && 0 <= y && y < hw[0] ) {
                    q.Enq( new Stat( x, y, p.Cst + t[y][x], p.Tkt ) );
                    if( 0 < p.Tkt ) {
                        q.Enq( new Stat( x, y, p.Cst, p.Tkt - 1 ) );
                    }
                }
            }
        }
        return;
    }
}
