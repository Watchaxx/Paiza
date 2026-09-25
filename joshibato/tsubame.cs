// 実行時間 20ms
using static System.Console;

class Program
{
    static void Main()
    {
        string n = ReadLine();
        WriteLine( int.Parse( n ) + int.Parse( n[0].ToString() ) + int.Parse( n[1].ToString() ) );
        return;
    }
}
