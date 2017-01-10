using System;
namespace DesignPatterns
{
	public interface ICharacterFactory
	{
		Character CreateCarry();
		Character createDisabler();
	}
}
