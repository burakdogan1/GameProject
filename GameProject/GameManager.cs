using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GameManager : IGameService
	{
		public void Add(List<Game> games, Game game)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUN EKLEME ************* ");

			Console.Write(" \n Eklemek İstediğiniz Oyunun Adını Giriniz : ");
			game.Name = Console.ReadLine();

			Console.Write(" \n Eklemek İstediğiniz Oyunun Fiyatını Giriniz : ");
			game.Price = Convert.ToInt32(Console.ReadLine());

			Console.Write(" \n Eklemek İstediğiniz Oyunun Boyunutu Giriniz : ");
			game.Size = Convert.ToInt32(Console.ReadLine());

			Console.Write(" \n Eklemek İstediğiniz Oyunun ID numarasını Giriniz : ");
			game.GameId = Convert.ToInt32(Console.ReadLine());

			games.Add(game);

			Listed(games);
		}

		public void Delete(List<Game> games)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUN SİLME ************* ");

			Console.Write(" \n Eklemek İstediğiniz Oyunun ID numarasını Giriniz : ");
			int ıd = Convert.ToInt32(Console.ReadLine());

			foreach (Game game in games)
			{
				if (game.GameId == ıd)
				{
					games.Remove(game);
					Console.WriteLine(" Silme İşlemi Başarılı");
					break;
				}
			}

			Listed(games);
		}

		public void Update(List<Game> games)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUN BİLGİLERİ GÜNCELLEME ************* ");

			Console.Write(" \n Güncelleme Yapmak İstediğiniz Oyunun ID numarasını Giriniz : ");
			int ıd = Convert.ToInt32(Console.ReadLine());

			foreach (Game game in games)
			{
				if (game.GameId == ıd)
				{
					Console.Write(" \n Güncelleme Yapmak İstediğiniz Oyunun Güncel Adını Giriniz : ");
					game.Name = Console.ReadLine();

					Console.Write(" \n Güncelleme Yapmak İstediğiniz Oyunun Fiyatını Güncel Giriniz : ");
					game.Price = Convert.ToInt32(Console.ReadLine());

					Console.Write(" \n  Güncelleme Yapmak İstediğiniz Oyunun Güncel Boyunutu Giriniz : ");
					game.Size = Convert.ToInt32(Console.ReadLine());
				}
			}

			Listed(games);
		}

		public void Listed(List<Game> games)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNLARI LİSTELEME ************* ");

			foreach (Game game in games)
			{
				Console.WriteLine(
					"\n Oyunun Adı : " + game.Name +
					"\n Oyunun Fİyatı : " + game.Price +
					"\n Oyunun Boyutu : " + game.Size +
					"\n Oyunun ID Numarasu : " + game.GameId);
			}

		}
	}
}
