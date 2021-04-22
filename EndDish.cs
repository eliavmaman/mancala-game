using System;

namespace Mancala
{
	public class EndDish : AbstractDish
	{
		public EndDish(Player owner, int dishNumber) : base(owner, dishNumber)
		{
		}

		public override int removeTokens()
		{
			throw new CannotRemoveTokensException("Cannot remove from end dishes");
		}

	}

	public class CannotRemoveTokensException : ApplicationException
	{	
		public CannotRemoveTokensException()
		{
		}

		public CannotRemoveTokensException(string message) : base(message)
		{			
		}

		public CannotRemoveTokensException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
