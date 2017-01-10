using System;
namespace DesignPatterns
{
	public class DireCharacterFactory : ICharacterFactory
	{
		public DireCharacterFactory()
		{
		}

		public Character CreateCarry()
		{
			return new Carry { Name = "Legion Commander", Team = "Dire" };
		}

		public Character createDisabler()
		{
			return new Disabler { Name = "Slardar", Team = "Dire" };
		}
	}
}
