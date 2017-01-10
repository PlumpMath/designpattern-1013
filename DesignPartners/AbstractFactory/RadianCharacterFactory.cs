using System;
namespace DesignPatterns
{
	public class RadianCharacterFactory : ICharacterFactory
	{
		public RadianCharacterFactory()
		{
		}

		public Character CreateCarry()
		{
			return new Carry { Name = "Juggernaut", Team = "Radian" };
		}

		public Character createDisabler()
		{
			return new Disabler { Name = "Pudge", Team = "Radian" };
		}
	}
}
