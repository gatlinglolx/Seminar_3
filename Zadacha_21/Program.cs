double Qwe(string name)
{
    Console.WriteLine(name);
    double Ax = Convert.ToDouble(Console.ReadLine());
    return Ax;
}
double Ax = Qwe("enter Ax");
double Ay = Qwe("enter Ay");
double Az = Qwe("enter Az");
double Bx = Qwe("enter Bx");
double By = Qwe("enter By");
double Bz = Qwe("enter Bz");
double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));
Console.WriteLine(AB);

