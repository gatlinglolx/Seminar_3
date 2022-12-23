int Qwe(string name)
{
    Console.WriteLine(name);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}
int N = Qwe("Enter N");
string answer = "";
for (int i = 1; i <= N; i++)
{
    answer = answer + Math.Pow(i, 3).ToString() + ", ";
}
Console.WriteLine(answer);
