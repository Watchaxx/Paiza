using System;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int X = int.Parse( ReadLine() );
        decimal l1 = 0;
        decimal l2 = 0;
        decimal l3 = 0;
        decimal l4 = 0;
        decimal l5 = 0;

        foreach( var i in Range( 1, 12 ) ) {
            int ld = 1;

            switch( i ) {
            case 1:
                ld = 31;
                break;
            case 2:
                ld = 28;
                break;
            case 3:
                ld = 31;
                break;
            case 4:
                ld = 30;
                break;
            case 5:
                ld = 31;
                break;
            case 6:
                ld = 30;
                break;
            case 7:
                ld = 31;
                break;
            case 8:
                ld = 31;
                break;
            case 9:
                ld = 30;
                break;
            case 10:
                ld = 31;
                break;
            case 11:
                ld = 30;
                break;
            case 12:
                ld = 31;
                break;
            }
            foreach( var j in Range( 1, 9999 ) ) {
                if( i == 2 ) {
                    ld = DateTime.IsLeapYear( j ) == true ? 29 : 28;
                }

                var dt = new DateTime( j, i, ld );

                if( dt.DayOfWeek == DayOfWeek.Saturday ) {
                    dt = dt.AddDays( -1d );
                } else if( dt.DayOfWeek == DayOfWeek.Sunday ) {
                    dt = dt.AddDays( -2d );
                }
                switch( dt.DayOfWeek ) {
                case DayOfWeek.Monday:
                    l1++;
                    break;
                case DayOfWeek.Tuesday:
                    l2++;
                    break;
                case DayOfWeek.Wednesday:
                    l3++;
                    break;
                case DayOfWeek.Thursday:
                    l4++;
                    break;
                case DayOfWeek.Friday:
                    l5++;
                    break;
                }
            }
        }

        decimal p = 0m;

        switch( X ) {
        case 1:
            p = l1 / ( l1 + l2 + l3 + l4 + l5 );
            break;
        case 2:
            p = l2 / ( l1 + l2 + l3 + l4 + l5 );
            break;
        case 3:
            p = l3 / ( l1 + l2 + l3 + l4 + l5 );
            break;
        case 4:
            p = l4 / ( l1 + l2 + l3 + l4 + l5 );
            break;
        case 5:
            p = l5 / ( l1 + l2 + l3 + l4 + l5 );
            break;
        }
        WriteLine( $"{p.ToString().Substring( 0, 8 )}" );
        return;
    }
}
