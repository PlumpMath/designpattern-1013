using System;

namespace DesignPatterns
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			MainClass mainClass = new MainClass();
			mainClass.InitializeTeam(new RadianCharacterFactory());
			mainClass.InitializeTeam(new DireCharacterFactory());
		}

		private void InitializeTeam(ICharacterFactory factory)
		{
			Character carry = factory.CreateCarry();
			Character disabler = factory.createDisabler();

			Console.WriteLine(carry.ToString());
			Console.WriteLine(disabler.ToString());
			Console.WriteLine();
		}
	}
}
