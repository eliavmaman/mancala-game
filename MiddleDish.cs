using System;

namespace Mancala
{
	public class MiddleDish : AbstractDish
	{
        
		public MiddleDish(Player owner, int dishNumber) : base(owner, dishNumber)
		{
			_tokens = 4;
		}
		
		public override int removeTokens()
		{
			int temp = this._tokens;
			this._tokens = 0;
			OnDishUpdate(this, new DishUpdateArgs(_tokens, _dishNumber));
			return temp;
		}
	}
}
