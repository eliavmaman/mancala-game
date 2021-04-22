using System;
using System.Runtime.Serialization;

namespace Mancala
{
	[Serializable()]
	public class Player : ISerializable
	{
		private string _name;
		private int _gamesWon;

		public Player() : this("Default")
		{
		}		

		public Player(string name)
		{
			_name = name;
			_gamesWon = 0;
		}

		public Player(SerializationInfo info, StreamingContext context)
		{
			_name = info.GetString("name");
			_gamesWon = info.GetInt32("gamesWon");
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("name", _name);
			info.AddValue("gamesWon", _gamesWon);
		}

		public int GamesWon
		{
			get { return _gamesWon; }
			set { _gamesWon = value; }
		}

		public override string ToString()
		{
			return _name;
		}
	}
}
