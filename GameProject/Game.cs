using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class Game : GameManager
	{
		public string Name { get; set; }
		public int Size { get; set; }
		public int Price { get; set; }
		public int GameId { get; set; }
		public int AfterPrice { get; set; }
	}
}
