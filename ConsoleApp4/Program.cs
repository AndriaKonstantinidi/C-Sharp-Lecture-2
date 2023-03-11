// See https://aka.ms/new-console-template for more information
int a, b, c;
a = 1;
b = 2;
c = 3;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//var bb = true;
//var fb = false;
//if (!bb == true)
//else if (fb == true && (bb == true && fb == false))
//    {
//        Console.WriteLine("Empty");
//    }
//    else
//    {
//        Console.WriteLine("Any");
//    }

var test = 12;
var me = 10;
switch (test)
{
    case 1: Console.WriteLine(1);
            break;
        case 10:
        Console.WriteLine(true);
            break;
    default:
        Console.WriteLine(test);
        break;
}