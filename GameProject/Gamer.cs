using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class Gamer : GamerManager
	{
		public string FirsName { get; set; }
		public string LastName { get; set; }
		public int YearofBirth { get; set; }
		public string NationalityId { get; set; }
		public string UserName { get; set; }
		public int UserId { get; set; }
		public List<Game> myGames = new List<Game>();
	}
}
