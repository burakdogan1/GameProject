using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class CampaignManager : ICampaignService
	{
		public void Add(List<Campaign> campaigns, Campaign campaign)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : KAMPANYA EKLEME ************* ");

			Console.Write(" \n Eklemek İstediğiniz Oyunun Adını Giriniz : ");
			campaign.Name = Console.ReadLine();

			Console.Write(" \n Eklemek İstediğiniz Oyunun Fiyatını Giriniz : ");
			campaign.DiscountRate = Convert.ToInt32(Console.ReadLine());

			Console.Write(" \n Eklemek İstediğiniz Oyunun ID numarasını Giriniz : ");
			campaign.CampaignId = Convert.ToInt32(Console.ReadLine());

			campaigns.Add(campaign);

			Listed(campaigns);
		}

		public void Update(List<Campaign> campaigns)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : KAMPANYA BİLGİLERİ GÜNCELLEME ************* ");

			Console.Write(" \n Güncelleme Yapmak İstediğiniz Kampanyanın ID numarasını Giriniz : ");
			int ıd = Convert.ToInt32(Console.ReadLine());

			foreach (Campaign campaign in campaigns)
			{
				if (campaign.CampaignId == ıd)
				{
					Console.Write(" \n Güncelleme Yapmak İstediğiniz Kampanyanın Güncel Adını Giriniz : ");
					campaign.Name = Console.ReadLine();

					Console.Write(" \n Güncelleme Yapmak İstediğiniz Kampanyanın Güncel ID Numarasını Giriniz : ");
					campaign.CampaignId = Convert.ToInt32(Console.ReadLine());

					Console.Write(" \n  Güncelleme Yapmak İstediğiniz Kampanyanın Güncel İndirim Oranını Giriniz : ");
					campaign.DiscountRate = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("\n Kampanya Bİlgileri GÜncellenmiştir");
				}
			}

			Listed(campaigns);
		}

		public void Delete(List<Campaign> campaigns)
		{
			Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : KAMPANYA SİLME ************* ");

			Console.Write(" \n Silmek İstediğiniz Kampanyanın ID numarasını Giriniz : ");
			int ıd = Convert.ToInt32(Console.ReadLine());

			foreach (Campaign campaign in campaigns)
			{
				if (campaign.CampaignId == ıd)
				{
					campaigns.Remove(campaign);
					Console.WriteLine("\n Kampanya Silinmiştir...");
				}
			}

			Listed(campaigns);
		}

		public void Listed(List<Campaign> campaigns)
		{
			foreach (Campaign campaign in campaigns)
			{
				Console.WriteLine("\n \n" + "**************  Gerçekleşen Eylem : KAMPANYA LİSTELEME ************* ");
				Console.WriteLine(
					"\n Kampanya adı: " + campaign.Name +
					"\n Kampanya İndirim Oranı: " + campaign.DiscountRate +
					"\n Kampanya ID Numarası: " + campaign.CampaignId);
			}
		}
	}
}
