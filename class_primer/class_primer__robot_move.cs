using System.Linq;
using static System.Console;

internal class Program
{
    class Robot
    {
        public int Px { get; set; }
        public int Py { get; set; }
        public int Lv { get; set; }

        public Robot( int[] a )
        {
            Px = a[0];
            Py = a[1];
            Lv = a[2];
        }

        public void Move( char d )
        {
            int[] len = { 0, 1, 2, 5, 10 };

            switch( d ) {
            case 'N':
                Py -= len[Lv];
                break;
            case 'S':
                Py += len[Lv];
                break;
            case 'E':
                Px += len[Lv];
                break;
            case 'W':
                Px -= len[Lv];
                break;
            }
            return;
        }
    }

    static void Main()
    {
        int[] HWNK = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] tx = new int[10];
        int[] ty = new int[10];
        Robot[] a = new Robot[HWNK[2]];

        foreach( int i in Enumerable.Range( 0, 10 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            tx[i] = t[0];
            ty[i] = t[1];
        }
        foreach( int i in Enumerable.Range( 0, HWNK[2] ) ) {
            a[i] = new Robot( ReadLine().Split().Select( int.Parse ).ToArray() );
        }
        foreach( int _ in Enumerable.Range( 0, HWNK[3] ) ) {
            string[] s = ReadLine().Split();
            int p = int.Parse( s[0] ) - 1;

            a[p].Move( s[1][0] );
            foreach( int i in Enumerable.Range( 0, tx.Length ) ) {
                if( a[p].Px == tx[i] && a[p].Py == ty[i] ) {
                    a[p].Lv = System.Math.Min( a[p].Lv + 1, 4 );
                    break;
                }
            }
        }
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( Robot r in a ) {
            WriteLine( $"{r.Px} {r.Py} {r.Lv}" );
        }
        Out.Flush();
        return;
    }
}
