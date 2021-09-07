using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class OrderManager : IOrderService
	{
		public void GameBuy(Game game,Gamer gamer, Campaign campaign)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUN SATIN ALMA ************* ");

			if (gamer.myGames.Count == 0) // Oyuncu ilk oyununu alıyor ise Oyun Hediye
			{
				Console.WriteLine("\n İlk Oyununuz Hediyemizdir. ");
				campaign.DiscountRate = 1;
			} 

			game.AfterPrice = game.Price - game.Price * campaign.DiscountRate;
				Console.WriteLine("\n Alınan Oyun: " + game.Name +
					"Ödenecek Tutar : " + game.AfterPrice);
				gamer.myGames.Add(game);
		}
	}
}
