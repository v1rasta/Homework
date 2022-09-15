// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double dx = xB - xA;
    double dy = yB - yA;
    double dz = zB - zA;
    double lenght = Math.Pow(dx*dx + dy*dy + dz*dz, 0.5);
    return lenght;
}
Console.WriteLine( "Введите координату x 1 точки:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Введите координату y 1 точки:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Введите координату z 1 точки:");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Введите координату x 2 точки:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Введите координату y 2 точки:");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Введите координату z 2 точки:");
double zB = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Длинна отрезка ({xA},{yA},{zA}) ({xB},{yB},{zB}) равна {Distance(xA, yA, zA, xB, yB, zB)}"); 
