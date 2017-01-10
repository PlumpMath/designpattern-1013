using System;
namespace DesignPatterns
{
	public class Character
	{
		public Character()
		{
			
		}

		public string Name { get; set; }
		public string Team { get; set; }
		protected CharacterRol Rol { get; set; }

		public override string ToString()
		{
			return string.Format("[Character: Name={0}, Team={1}]", Name, Team);
		}
	}
}
