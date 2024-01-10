Random rnd = new Random();
stat Status = new stat();
enemy monster = new enemy();

int patk;
int eatk;

Console.WriteLine("Attributes:\nHealth = " + Status.hp + $"\nAttack = {Status.atk[0]}-{Status.atk[1]}" + "\nDefence = " + Status.def);

try
{
	Console.ReadKey();
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

while(true)
{
	patk = rnd.Next(Status.atk[1]);
	eatk = rnd.Next(monster.atk[1]);
	monster.hp -= patk;
	Status.hp -= eatk;

	Console.WriteLine("The enemy has taken -" + patk + "damage.\nEnemy's HP left: " + monster.hp);
	Console.ReadKey();
	if (monster.hp <= 0)
	{
		Console.WriteLine("The enemy has fallen. Victory!");
		Console.ReadKey();
		break;
	}

	Console.WriteLine("You have taken -" + eatk + " damage.\nYour HP left: " + Status.hp);
	Console.ReadKey();
	if (Status.hp <= 0)
	{
		Console.WriteLine("You have been defeated!");
		Console.ReadKey();
		break;
	}
}


class stat
{
	public int hp = 100;
	public int[] atk = {20, 24};
	public int def = 10;
}

class enemy
{
	public int hp = 100;
	public int[] atk = {30, 32};
}