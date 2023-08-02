using System;
namespace mvc_countries_lab
{
	public class CountryView
	{
		//properties
		public Country DisplayCountry { get; set; }

		//constructor
		//display individual country view
		public CountryView(Country _country)
		{
			DisplayCountry = _country;
		}

		//methods
		public void Display()
		{
			Console.WriteLine($"Name:");
			//Console.Write() to display inline
		}
	}
}

