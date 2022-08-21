int a = 2;
int b = 10;
int c = 1;
int d = 4;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;

Console.Write("max = ");
Console.WriteLine(max);