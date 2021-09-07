using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager : IGamerService
	{	
		public void Add(List<Person> persons, List<Gamer> gamers, Gamer gamer, IGamerValidationService gamerValidationManager)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNCU EKLEME ************* "); 

			Console.Write(" \n Oyuncunun Adını Giriniz : ");
			gamer.FirsName = Console.ReadLine();

			Console.Write(" \n Oyuncunun Soyadını Giriniz : ");
			gamer.LastName = Console.ReadLine();

			Console.Write(" \n Oyuncunun Doğum Yılını Giriniz : ");
			gamer.YearofBirth = Convert.ToInt32(Console.ReadLine());

			Console.Write("\n  Oyuncunun Kullanıcı Kimlik Numarasını Giriniz : ");
			gamer.NationalityId= Console.ReadLine();
			
			Console.Write(" \n Kimlik Doğrulama işlemi :  ");

			if (gamerValidationManager.Validation(persons,gamer)==true)
			{
				Console.Write(" \n Oyuncunun Kullanıcı Adını Giriniz : ");
				gamer.UserName = Console.ReadLine(); 

				Console.Write(" \n Oyuncunun Kullanıcı Id'sini Giriniz : ");
				gamer.UserId = Convert.ToInt32(Console.ReadLine());

				gamers.Add(gamer);

				Console.WriteLine(" \n \n" + gamer.FirsName + " " + gamer.LastName + " İsimli Oyuncu " + gamer.UserName + " Kullanıcı adı ile eklendi");
			}

			Listed(gamers);
		}

		public void Delete(List<Gamer> gamers)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNCU SİLME ************* ");

			Console.Write("\n \n Silinecek Oyuncuyunun Kullaıcı Adını Giriniz :  ");
			string userName = Console.ReadLine();
			foreach (Gamer gamer in gamers)
			{
				if (gamer.UserName== userName)
				{
					gamers.Remove(gamer);
					Console.WriteLine("\n Silme İşlemi Başarılı ");
					break;
				}
			}

			Listed(gamers);
		}


		public void Update(List<Gamer> gamers)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNCU GÜNCELLEME ************* "); 

			Console.Write("\n \n Güncellenecek Oyuncuyunun Kullaıcı Adını Giriniz :  ");
			string userName = Console.ReadLine();

			foreach (Gamer gamer in gamers)
			{
				if (gamer.UserName == userName)
				{
					Console.Write(" \n Oyuncunun Adını Giriniz : ");
					gamer.FirsName = Console.ReadLine();

					Console.Write(" \n Oyuncunun Soyadını Giriniz : ");
					gamer.LastName = Console.ReadLine();

					Console.Write(" \n Oyuncunun Kullanıcı Adını Giriniz : ");
					gamer.UserName = Console.ReadLine();

					Console.Write(" \n Oyuncunun Doğum Yılını Giriniz : ");
					gamer.YearofBirth = Convert.ToInt32(Console.ReadLine());

					Console.Write(" \n Oyuncunun Kullanıcı Kimlik Numarasını Giriniz : ");
					gamer.NationalityId = Console.ReadLine();

					Console.Write(" \n Oyuncunun Kullanıcı Id'sini Giriniz : ");
					gamer.UserId = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("\n \n**********  Oyuncu Bilgileri : **********" + 
						"\n Oyuncu adı : " + gamer.FirsName + 
						"\n Oyoncu Soyadı : " +gamer.LastName +
						"\n Oyuncu Kullanıcı ad : " + gamer.UserName +
						"\n Oyuncu Doğum Yılı : " + gamer.YearofBirth +
						"\n Oyuncu Kullanıcı Kimlik Numrası : " + gamer.NationalityId +
						"\n Oyuncu Kullanıcı ID : " + gamer.UserId );
					Console.WriteLine(" \n \n");
					break;
				}
			}
			Listed(gamers);
		}

		public void Listed(List<Gamer> gamers)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNCU LİSTELEME ************* ");

			foreach (Gamer gamer in gamers)
			{
				Console.WriteLine(
					"\n Oyuncu Adı : " + gamer.FirsName +
					"\n Oyoncu Soyadı : " + gamer.LastName +
					"\n Oyuncu Kullanıcı ad : " + gamer.UserName +
					"\n Oyuncu Doğum Yılı : " + gamer.YearofBirth +
					"\n Oyuncu Kullanıcı Kimlik Numrası : " + gamer.NationalityId +
					"\n Oyuncu Kullanıcı ID : " + gamer.UserId);
			}
		}
		
		public void GameAdd(Gamer gamer, Game game)
		{
			gamer.myGames.Add(game);
		}

		public void MyGamesListed(Gamer gamer)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : OYUNCUNUN OYUNLARI ************* ");

			Console.WriteLine("\n Oyuncu Adı : " + gamer.FirsName + "Oyoncu Soyadı : " + gamer.LastName);

			foreach (Game game in gamer.myGames)
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
