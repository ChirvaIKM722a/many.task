///Пошук числа в масиві

int pup;

int[] values = new int[10];
    values[0] = 17;
    values[1] = 25;
    values[2] = 32;
    values[3] = 45;
    values[4] = 56;
    values[5] = 68;
    values[6] = 74;
    values[7] = 88;
    values[8] = 90;
    values[9] = 102;

Console.WriteLine("Nash maasiv values:");
    Console.WriteLine(values[0]);
    Console.WriteLine(values[1]);
    Console.WriteLine(values[2]);
    Console.WriteLine(values[3]);
    Console.WriteLine(values[4]);
    Console.WriteLine(values[5]);
    Console.WriteLine(values[6]);
    Console.WriteLine(values[7]);
    Console.WriteLine(values[8]);
    Console.WriteLine(values[9]);

Console.WriteLine("Vvedite iskomoe chislo:");
pup = int.Parse(Console.ReadLine());

if (values.Contains(pup))
{
    Console.WriteLine("Chislo " + pup + " mistitsya v masivi.");
}
else
{
    Console.WriteLine("Chislo " + pup + " ne mistitsya v masivi.");
}

///Перевод цельсій --> фаренгейт

double celsiq;

Console.WriteLine("Enter temperature in Celsius");
celsiq = double.Parse(Console.ReadLine());

double farengeit = (celsiq * 1.8) + 32;

Console.WriteLine("Amount of temperature in farenheit");
Console.WriteLine(farengeit);


///рішення квадратного рівнння ax^2 + bx + c = 0


double a;
double b;
double c;

Console.WriteLine("Quadratic equation ax^2 + bx + c = 0. ");

Console.WriteLine("Enter a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter c");
c = double.Parse(Console.ReadLine());

double deskremenant = Math.Pow(b, 2) - 4 * a * c;
if (deskremenant < 0)
{
    Console.WriteLine("Eror: discriminant less than zero");
}
else if (deskremenant == 0)
{
    Console.WriteLine("You have one root, because the discriminant is zero");

    double korennull = (-b) / (2 * a);
    Console.WriteLine(korennull);
}
else if (deskremenant > 0)
{
    Console.WriteLine("The discriminant is greater than zero, so you have 2 roots");

    double koren1 = ((-b) + Math.Sqrt(deskremenant)) / (2 * a);
    double koren2 = ((-b) - Math.Sqrt(deskremenant)) / (2 * a);

    Console.WriteLine(koren1);
    Console.WriteLine(koren2);
}




















