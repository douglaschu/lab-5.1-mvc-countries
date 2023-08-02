using System;
namespace mvc_countries_lab
{
	public class CountryController
	{
		//properties
		List<Country> CountryDb
		{

		}

		//methods
		public void CountryAction(Country c)
		{

		}

		public void WelcomeAction()
		{
			//CountryListView(CountryDb)
			Console.WriteLine("Hello, welcome the country app. Please select a country from the following list:");
			//CountryListView.Display();
		}

	}
}

