using System;
using System.Runtime.Serialization;

namespace Mancala
{
	public delegate void TurnOverDelegate(Player currentPlayer);
	public delegate void GameOverDelegate(Player winner);

	[Serializable()]
	public class Board : ISerializable 
	{
		private Player _player1;
		private Player _player2;
		private Player _currentPlayer;
		private AbstractDish[] _dishes = new AbstractDish[14];
		private EndDish _player1End;
		private EndDish _player2End;

		public event TurnOverDelegate turnOver;
		public event DishUpdateDelegate dishUpdate;
		public event GameOverDelegate gameOver;
		
		public Board(Player one, Player two)
		{
			_player1 = one;
			_player2 = two;
			_currentPlayer = _player1;
			
			// config the board
			for (int i = 0; i < 6; i++)
			{
				_dishes[i] = new MiddleDish(_player1, i);
				_dishes[i].dishUpdate += new DishUpdateDelegate(DishUpdate);
			}
			_dishes[6] = new EndDish(_player1, 6);
			_dishes[6].dishUpdate += new DishUpdateDelegate(DishUpdate);
			_player1End = (EndDish)_dishes[6];
			for (int i = 7; i<13; i++)
			{
				_dishes[i] = new MiddleDish(_player2, i );
				_dishes[i].dishUpdate += new DishUpdateDelegate(DishUpdate);
			}
			_dishes[13] = new EndDish(_player2, 13);
			_dishes[13].dishUpdate += new DishUpdateDelegate(DishUpdate);
			_player2End = (EndDish)_dishes[13];
		}

		#region ISerializable Members
		
		public Board(SerializationInfo info, StreamingContext context)
		{
			// TODO: Implement Serialization		
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// TODO:  Add Board.GetObjectData implementation
		}

		#endregion

		public Player CurrentPlayer
		{
			get { return _currentPlayer; }
		}

		public void TakeTurn(int iDish)
		{
			AbstractDish dish = _dishes[iDish];
			if (dish is MiddleDish)
			{	
				// check if dish clicked in belongs to current player
				if (dish.Owner != _currentPlayer)
				{
					throw new Exception("Cannot move opponents tokens!");
				}

				if (dish.HasTokens) 
				{		
					int tokens = dish.removeTokens();
					for (int i = 1; i <= tokens; i++)
					{						
						iDish = ++iDish % 14;
						dish = _dishes[iDish];
						if (dish is EndDish && dish.Owner != _currentPlayer)
						{
							// don't drop					
							iDish = ++iDish % 14;
							dish = _dishes[iDish];
						}
						dish.dropToken();
					}

					// check if dish has only one token and stopped on yours.
					if (dish.Tokens == 1 && dish.Owner == _currentPlayer && !(dish is EndDish))
					{
						// claim all oppositions (and yours)
						int oppDish = (6 + (6 - iDish));
						AbstractDish oppositeDish = _dishes[oppDish];						
						if (_currentPlayer == _player1)
						{
							_player1End.dropToken(oppositeDish.removeTokens());
							_player1End.dropToken(dish.removeTokens());
						}
						else 
						{
							_player2End.dropToken(oppositeDish.removeTokens());
							_player2End.dropToken(dish.removeTokens());
						}							
					}
					
					// check for win-state
					Player winner = null;
					if (this.IsGameOver(ref winner))
					{
						// current player must have won
						// move all other player's tokens to their win bin
						Player loser;
						EndDish endDish;
						//if (winner == _player1)
						//{
						//	loser = _player2;
						//	endDish = _player2End;
						//}
						//else
						//{
						//	loser = _player1;
						//	endDish = _player1End;
						//}
						//foreach (AbstractDish d in _dishes)
						//{
						//	if (d is MiddleDish && d.Owner == loser)
						//	{
						//		endDish.dropToken(d.removeTokens());
						//	}
						//}
						// determine winner by size of mancala's
						if (_player1End.Tokens > _player2End.Tokens)
							OnGameOver(_player1);
						else if (_player2End.Tokens > _player1End.Tokens)
							OnGameOver(_player2);
						else
							OnGameOver(null);

					} 
					else
					{
						// player gets another go if they drop their last token
						// in their end dish.
						if (!(dish is EndDish && dish.Owner == _currentPlayer))
						{
							_currentPlayer = this.NextPlayer();
						}
						OnTurnOver(_currentPlayer);
					}
				}
				else
				{
					throw new Exception("This dish has no tokens!");
				}
			} 
			else
			{
				throw new Exception("Cannot take from end dish!");
			}
		}

		protected virtual void OnTurnOver(Player current)
		{
			if (turnOver != null)
			{
				turnOver(current);
			}
		}

		private Player NextPlayer()
		{
			if (_currentPlayer == _player1)
				return _player2;
			else
				return _player1;
		}

		private void DishUpdate(object sender, DishUpdateArgs args)
		{
			OnDishUpdate(this, args);
		}

		protected virtual void OnDishUpdate(object sender, DishUpdateArgs args)
		{
			if (this.dishUpdate != null)
			{
				dishUpdate(sender, args);
			}
		}

		protected virtual void OnGameOver(Player winner)
		{
			if (gameOver != null)
			{
				gameOver(winner);
			}
		}

		private bool IsGameOver(ref Player winner)
		{
			bool player1Empty = true;
			bool player2Empty = true;

			// check player 1
			for (int i = 0; i < 6; i++)
			{
				if (_dishes[i].HasTokens)
				{
					player1Empty = false;
					break;
				}
			}

			// check player 2
			for (int i = 7; i < 13; i++)
			{
				if (_dishes[i].HasTokens)
				{
					player2Empty = false;
					break;
				}
			}
            return player1Empty && player2Empty;
            //if (player1Empty && player2Empty)
            //{
            //	winner = null;
            //	return true;
            //} 
            //else if (player1Empty)
            //{
            //	winner = _player1;
            //	return true;
            //}
            //else if (player2Empty)
            //{
            //	winner = _player2;
            //	return true;
            //}
            //else
            //{
            //	return false;
            //}
        }

		public void Refresh()
		{
			foreach (AbstractDish dish in _dishes)
			{
				dish.Refresh();
			}
			OnTurnOver(_currentPlayer); //doesn't actually mean end of turn
		}
	}
}
