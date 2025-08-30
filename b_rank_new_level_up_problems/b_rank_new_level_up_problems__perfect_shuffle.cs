// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Cards
    {
        public string Card { get; set; }
        public int Num { get; set; } = 0;

        public Cards( string s )
        {
            Card = s;
        }
    }

    static void Main()
    {
        int k = int.Parse( ReadLine() );
        string[] kind = { "S", "H", "D", "C" };
        var l = new System.Collections.Generic.List<Cards>( 52 );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, 4 ) ) {
            foreach( int j in Range( 1, 13 ) ) {
                l.Add( new Cards( $"{kind[i]}_{j}" ) );
            }
        }
        foreach( int _ in Range( 0, k ) ) {
            foreach( int i in Range( 0, l.Count ) ) {
                l[i].Num = i < 26 ? i * 2 : ( i - 26 ) * 2 + 1;
            }
            l.Sort( ( a, b ) => a.Num - b.Num );
        }
        foreach( Cards c in l ) {
            WriteLine( c.Card );
        }
        Out.Flush();
        return;
    }
}
