Console.Write("Введите имя: ");
string username = Console.ReadLine();
int count = 0;
Console.Clear();
if (username.ToLower() == "cat") //ToLower() буквы строчные=прописные (cat должно быть с маленькой буквы)
{
	while (count < 10)
	{
		Console.Write("Здорова Cat!");
		Console.WriteLine(username);
		count++;
	}
}
else
{
	Console.Write("Привет ");
	Console.WriteLine(username); 
}

// End hello

Console.Clear();
int xa = 40, ya = 1,
	xb = 1, yb = 25,
	xc = 80, yc = 25;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int cnt = 0;

while (cnt < 5000)
{
	int what = new Random().Next(0, 3);
	if (what == 0)
	{
		x = (x + xa) / 2;
		y = (y + ya) / 2;
	}
	if (what == 1)
	{
		x = (x + xb) / 2;
		y = (y + yb) / 2;
	}
	if (what == 2)
	{
		x = (x + xc) / 2;
		y = (y + yc) / 2;
	}
	Console.SetCursorPosition(x, y);
	Console.WriteLine("+");
	cnt++;
}
// End