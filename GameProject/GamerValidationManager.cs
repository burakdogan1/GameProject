using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerValidationManager : IGamerValidationService
	{
		public bool Validation(List<Person> persons, Gamer gamer)
		{
			bool value = false;
			foreach (Person person in persons)
			{
				if (person.FirsName == gamer.FirsName && person.LastName == gamer.LastName && person.NationalityId == gamer.NationalityId && person.YearofBirth == gamer.YearofBirth)
				{
					Console.Write(" BAŞARILI ________");
					Console.WriteLine(" Doğrulama Sistemi : GamerValidationManager ");
					value = true;
					break;
				}

				if (person.FirsName != gamer.FirsName && person.LastName != gamer.LastName && person.NationalityId != gamer.NationalityId && person.YearofBirth != gamer.YearofBirth)
				{
					Console.WriteLine("!! BAŞARISIZ _!_!_!_!_!_!_!_!_!_!");
					value = false;
					break;
				}
			}
			
			return value;
		}

			
	}
}
