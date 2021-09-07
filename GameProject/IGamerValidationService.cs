using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface IGamerValidationService
	{
		bool Validation(List<Person> persons, Gamer gamer);
	}
}
