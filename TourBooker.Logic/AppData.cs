using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{
	public class AppData
	{
		public List<Country> AllCountries { get; private set; }
		public SortedList<string, Country> AllCountriesByKey { get; private set; }
		public void Initialize(string csvFilePath)
		{
			CsvReader reader = new CsvReader(csvFilePath);
			AllCountries = reader.ReadAllCountries().OrderBy(c => c.Name).ToList();
			var dict = AllCountries.ToDictionary(c => c.Code, StringComparer.OrdinalIgnoreCase);
			AllCountriesByKey = new SortedList<string, Country>(dict);
		}
	}
}
