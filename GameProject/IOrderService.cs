using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface IOrderService
	{
		void GameBuy(Game game, Gamer gamer,Campaign campaign);
	}
}
