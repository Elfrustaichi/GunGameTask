using ConsoleApp1.Implementations;

Methods Gun = new();
repeat:

Console.WriteLine("Welcome to our Gun simulator");
Console.WriteLine("1.Shoot one by one");
Console.WriteLine("2.Shoot all bullets");
Console.WriteLine("3.Reload...");
Console.WriteLine("4.Exit from simulation.");
Console.WriteLine("5.Show how much bullets left");
Console.Write("Give your Order----");
int.TryParse(Console.ReadLine(), out int Order);


switch (Order)
{
	case 1:
		Console.Clear();
		Gun.Shoot();
		goto repeat;
	case 2:
		Console.Clear();
		Gun.ShootAll();
		goto repeat;
	case 3:
		Console.Clear();
		Gun.Reload();
		goto repeat;
	case 4:
		return;
	case 5:
		Console.Clear();
		Gun.ShowBullets();
		goto repeat;
	case 0:
		Console.Clear();
		Console.WriteLine("Invalid order try again...");
		goto repeat;
	default:
		Console.Clear();
		Console.WriteLine("Invalid order try again....");
		goto repeat;
}
