using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface IGamerService
	{
		void Add(List<Person> persons, List<Gamer> gamers, Gamer gamer, IGamerValidationService gamerValidationManager);
		void Update(List<Gamer> gamers);
		void Delete(List<Gamer> gamers);
		void Listed(List<Gamer> gamers);
		void GameAdd(Gamer gamer, Game game);
		void MyGamesListed(Gamer gamer);
	}
}
