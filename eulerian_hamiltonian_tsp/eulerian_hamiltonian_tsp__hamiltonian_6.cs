// 実行時間 20ms
using static System.Console;

class Program
{
    static void Main()
    {
        int[] n = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        WriteLine( ( n[0] & ( 1 << n[1] ) ) != 0 ? "Yes"
            : $"No{System.Environment.NewLine}{n[0] | ( 1 << n[1] )}" );
        return;
    }
}
