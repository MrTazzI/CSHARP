int a = 6;
int b = 17;
int c = 9;
int d = 4;
int e = 10;

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
if (max < d)
{
    max = d;
}
if (max < e)
{
    max = e;
}
Console.WriteLine(max);