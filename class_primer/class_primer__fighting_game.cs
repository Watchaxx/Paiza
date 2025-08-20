using System.Linq;
using static System.Console;

internal class Program
{
    class Player
    {
        internal int Hlt { get; set; }
        internal int[] Atk { get; set; }
        internal int[] Frm { get; set; }

        internal Player( int[] a )
        {
            Hlt = a[0];
            Frm = new int[] { a[1], a[3], a[5] };
            Atk = new int[] { a[2], a[4], a[6] };
        }

        internal void Enhance( int a )
        {
            foreach( int i in Enumerable.Range( 0, 3 ).Where( i => i != a ) ) {
                Atk[i] += 5;
                Frm[i] = System.Math.Max( Frm[i] - 3, 1 );
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Player[] a = new Player[n[0]];

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            a[i] = new Player( ReadLine().Split().Select( int.Parse ).ToArray() );
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
            int a1 = t[1];
            int a2 = t[3];
            Player p1 = a[t[0]];
            Player p2 = a[t[2]];

            if( p1.Hlt <= 0 || p2.Hlt <= 0 ) {
                continue;
            }
            if( p1.Atk[a1] == 0 && p1.Frm[a1] == 0 ) {
                p1.Enhance( a1 );
                if( p2.Atk[a2] == 0 && p2.Frm[a2] == 0 ) {
                    p2.Enhance( a2 );
                } else {
                    p1.Hlt -= p2.Atk[a2];
                }
            } else if( p2.Atk[a2] == 0 && p2.Frm[a2] == 0 ) {
                p2.Hlt -= p1.Atk[a1];
                p2.Enhance( a2 );
            } else {
                if( p1.Frm[a1] < p2.Frm[a2] ) {
                    p2.Hlt -= p1.Atk[a1];
                } else if( p2.Frm[a2] < p1.Frm[a1] ) {
                    p1.Hlt -= p2.Atk[a2];
                }
            }
        }
        WriteLine( a.Count( x => 0 < x.Hlt ) );
        return;
    }
}
