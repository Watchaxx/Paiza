// 実行時間 20ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        WriteLine( ReadLine().Split( ' ' ).Count( x => x == "0" ) );
        return;
    }
}
