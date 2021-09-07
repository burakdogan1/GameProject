using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface IGameService
	{
		void Add(List<Game> games, Game game);
		void Update(List<Game> games);
		void Delete(List<Game> games);
		void Listed(List<Game> games);
	}
}
