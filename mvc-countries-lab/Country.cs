using System;
//Model

namespace mvc_countries_lab
{
	public class Country
	{
		public enum Continent
		{
			Africa,
			Asia,
			Europe,
			NorthAmerica,
			SouthAmerica,
			Oceania,
			Antarctica
		}

		//properties
		public string Name { get; set; }
		public Continent CountryContinent { get; set; }
		public List<string> Colors { get; set; }
		//populate list?
		//constructor
		//no constructor?

		//params string array
		//public Country (string _name, Continent _continent, params string[] _colors)

		//ForEach linq to display on one line 
		
	}
}

