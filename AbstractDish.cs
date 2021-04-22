using System;
using System.Runtime.Serialization;

namespace Mancala
{
	public class DishUpdateArgs : EventArgs
	{
		private readonly int _tokens;
		private readonly int _dishNumber;

		public DishUpdateArgs(int tokens, int dishNumber) 
		{
			_tokens = tokens;
			_dishNumber = dishNumber;
		}

		public int Tokens
		{
			get { return _tokens; }
		}

		public int DishNumber
		{
			get { return _dishNumber; }
		}
	}

	public delegate void DishUpdateDelegate(object sender, DishUpdateArgs tokens);

	[Serializable()]
	public abstract class AbstractDish : ISerializable
	{		
		protected readonly Player _owner = null;
		protected int _tokens = 0;
		protected readonly int _dishNumber = -1;

		public event DishUpdateDelegate dishUpdate;

		public AbstractDish(Player owner, int dishNumber)
		{
			_owner = owner;	
			_dishNumber = dishNumber;
		}

		#region ISerializable Members

		public AbstractDish(SerializationInfo info, StreamingContext context)
		{
			//_owner = info.GetValue("owner", Player);
			_tokens = info.GetInt32("tokens");
			_dishNumber = info.GetInt32("dishNumber");
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("owner", _owner);
			info.AddValue("tokens",  _tokens);
			info.AddValue("dishNumber", _dishNumber);			
		}

		#endregion

		public Player Owner
		{
			get { return _owner; }
		}

		public abstract int removeTokens();

		public virtual void dropToken()
		{
			_tokens++;
			OnDishUpdate(this, new DishUpdateArgs(_tokens, _dishNumber));
		}

		public virtual void dropToken(int tokens)
		{
			_tokens+=tokens;
			OnDishUpdate(this, new DishUpdateArgs(_tokens, _dishNumber));
		}

		public bool HasTokens
		{
			get { return _tokens > 0; }
		}

		public int Tokens
		{
			get { return _tokens; }
		}

		protected virtual void OnDishUpdate(object sender, DishUpdateArgs args)
		{
			if (dishUpdate != null)
			{
				dishUpdate(sender, args);
			}
		}

		public void Refresh()
		{
			OnDishUpdate(this, new DishUpdateArgs(_tokens, _dishNumber));
		}		
	}
}
