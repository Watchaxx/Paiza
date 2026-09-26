// 実行時間 20ms
using System.Linq;
using static System.Console;

class Program
{
    static void Main()
    {
        foreach( var p in ReadLine().Select( ( v, i ) => new { v, i } ) ) {
            if( ( p.i & 1 ) == 0 ) {
                Write( p.v );
            }
        }
        return;
    }
}
