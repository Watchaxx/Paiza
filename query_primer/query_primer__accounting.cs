//何故か AutoFlush = true かつクラスを使わないとエラーになる
using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    class Purchase
    {
        public string Id { get; set; }
        public string Price { get; set; }

        public Purchase( string p, string m )
        {
            Id = p;
            Price = m;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        var d = new Dictionary<string, List<Purchase>>( n[0] );

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            d.Add( ReadLine(), new List<Purchase>() );
        }
        foreach( int i in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split( ' ' );

            d[s[0]].Add( new Purchase( s[1], s[2] ) );
        }
        foreach( KeyValuePair<string, List<Purchase>> p in d ) {
            WriteLine( p.Key );
            foreach( Purchase v in p.Value ) {
                WriteLine( $"{v.Id} {v.Price}" );
            }
            WriteLine( "-----" );
        }
        return;
    }
}
