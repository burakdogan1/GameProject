using System;
using System.Collections.Generic;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person() { FirsName = "Burak", LastName = "Doğan", NationalityId = "123", YearofBirth = 1998 };
			Person person2 = new Person() { FirsName = "Muhammed", LastName = "Doğan", NationalityId = "456", YearofBirth = 1991 };
			Person person3 = new Person() { FirsName = "Serap", LastName = "Adalmış", NationalityId = "789", YearofBirth = 1986 };

			Campaign campaign1 = new Campaign() { CampaignId = 1, DiscountRate = 1 / 4, Name = "Yaz Dönemi" };
			Campaign campaign2 = new Campaign() { CampaignId = 2, DiscountRate = 1 / 2, Name = "Bahar Dönemi" };

			List<Person> persons = new List<Person>() { person1, person2, person3 };
			List<Game> games = new List<Game>() { };
			List<Gamer> gamers = new List<Gamer>();
			List<Campaign> campaigns = new List<Campaign>() { campaign1, campaign2 };

			GamerValidationManager gamerValidationManager = new GamerValidationManager();
			NewGamerValidationManager newGamerValidation = new NewGamerValidationManager();

			GameManager gameManager = new GameManager();
			GamerManager gamerManager = new GamerManager();
			OrderManager orderManager = new OrderManager();

			Game game1 = new Game();
			Game game2 = new Game();
			Game game3 = new Game();


			Gamer gamer1 = new Gamer();
			Gamer gamer2 = new Gamer();
			Gamer gamer3 = new Gamer();

			gameManager.Add(games, game1);
			gameManager.Add(games, game2);
			gameManager.Add(games, game3);

			gamerManager.Add(persons, gamers, gamer1, gamerValidationManager);
			gamerManager.Add(persons, gamers, gamer2, newGamerValidation);
			gamerManager.Add(persons, gamers, gamer3, gamerValidationManager);

			gamerManager.Update(gamers);

			gamerManager.Delete(gamers);

			gamerManager.GameAdd(gamer1, game1);
			gamerManager.GameAdd(gamer1, game2);
			gamerManager.GameAdd(gamer1, game3);

			orderManager.GameBuy(game1,gamer1,campaign2);

			gamerManager.MyGamesListed(gamer1);

		}
	}
}
