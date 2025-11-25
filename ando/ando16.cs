// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        ReadLine();
        ReadLine();
        var x = ReadLine().Split().Select( int.Parse );
        ReadLine();
        var y = ReadLine().Split().Select( int.Parse );
        var z = y.Except( x ).OrderBy( a => a );

        WriteLine( 0 < z.Count() ? string.Join( " ", z ) : "None" );
        return;
    }
}
