using static System.Console;

internal class Program
{
    class Person
    {
        int Old;
        string Birth;
        string Name;
        string State;

        public Person( string n, int o, string b, string s )
        {
            Name = n;
            Old = o;
            Birth = b;
            State = s;
        }

        public void Print()
        {
            WriteLine( "User{" );
            WriteLine( $"nickname : {Name}" );
            WriteLine( $"old : {Old}" );
            WriteLine( $"birth : {Birth}" );
            WriteLine( $"state : {State}" );
            WriteLine( "}" );
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int _ = 0; _ < n; _++ ) {
            string[] s = ReadLine().Split();
            Person p = new Person( s[0], int.Parse( s[1] ), s[2], s[3] );

            p.Print();
        }
        return;
    }
}
