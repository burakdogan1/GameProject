using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface ICampaignService
	{
		void Add(List<Campaign> campaigns, Campaign campaign);
		void Update(List<Campaign> campaigns);
		void Delete(List<Campaign> campaigns);
		void Listed(List<Campaign> campaigns);
	}
}
