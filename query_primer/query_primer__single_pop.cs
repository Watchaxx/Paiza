using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        ReadLine();
        for( int _ = 1; _ < n; _++ ) {
            WriteLine( ReadLine() );
        }
        Out.Flush();
        return;
    }
}
