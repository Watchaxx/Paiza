using System.Linq;
using static System.Console;

internal class Program
{
    class Hero
    {
        int Agi { get; set; }
        int Atk { get; set; }
        int Def { get; set; }
        int Hlt { get; set; }
        int Int { get; set; }
        int Luc { get; set; }
        int Lvl { get; set; }

        internal Hero( int[] a )
        {
            Lvl = a[0];
            Hlt = a[1];
            Atk = a[2];
            Def = a[3];
            Agi = a[4];
            Int = a[5];
            Luc = a[6];
        }

        internal void LevelUp( int[] a )
        {
            Lvl++;
            Hlt += a[0];
            Atk += a[1];
            Def += a[2];
            Agi += a[3];
            Int += a[4];
            Luc += a[5];
            return;
        }

        internal void MuscleTraining( int[] a )
        {
            Hlt += a[0];
            Atk += a[1];
            return;
        }

        internal void Running( int[] a )
        {
            Def += a[0];
            Agi += a[1];
            return;
        }

        internal void Study( int[] c )
        {
            Int += c[0];
            return;
        }

        internal void Pray( int[] f )
        {
            Luc += f[0];
            return;
        }

        internal void Print()
        {
            WriteLine( $"{Lvl} {Hlt} {Atk} {Def} {Agi} {Int} {Luc}" );
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Hero[] h = new Hero[n[0]];

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            h[i] = new Hero( ReadLine().Split().Select( int.Parse ).ToArray() );
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();
            int t = int.Parse( s[0] ) - 1;
            int[] a = s.Skip( 2 ).Select( int.Parse ).ToArray();

            switch( s[1] ) {
            case "levelup":
                h[t].LevelUp( a );
                break;
            case "muscle_training":
                h[t].MuscleTraining( a );
                break;
            case "running":
                h[t].Running( a );
                break;
            case "study":
                h[t].Study( a );
                break;
            case "pray":
                h[t].Pray( a );
                break;
            }
        }
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( Hero i in h ) {
            i.Print();
        }
        Out.Flush();
        return;
    }
}
