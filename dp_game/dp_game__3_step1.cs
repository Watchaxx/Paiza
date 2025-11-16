// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            o += t[1] / 100 * t[0];
            /*
            本来なら t[0](確率)を 100 で割るべきだが，
            t[1](金額)が 100 の倍数しか入力されない制約から
            誤差を無くしつつ o に入る値を小さくするために t[1] を割る
            */
        }
        WriteLine( o );
        return;
    }
}
