using System;
using System.Collections.Generic;

namespace Assignment4
{
	enum Values
	{
		Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
	}

	enum Suits
	{
		Clubs, Diamonds, Hearts, Spades
	}

	class Card
	{
		public Values Value { get; private set; }
		public Suits Suit { get; private set; }

		public Card(Values value, Suits suit)
		{
			Value = value;
			Suit = suit;
		}

		public override string ToString()
		{
			return $"{Value} of {Suit}";
		}
	}

	class CardComparerByValue : IComparer<Card>
	{
		/// <summary>
		/// Value order is intuitive going in ascending order from A,2,...,Q,K
		/// Suit should be ordered as follows: Clubs, Diamonds, Hearts, Spades (same as enum ordering)
		/// </summary>
		public int Compare(Card a, Card b)
		{
			// TODO: IMPLEMENT THIS
			/// <summary>
			/// Here I am comparing card a and card b.
			/// First I am compare card a.Suit to card b.Suit, If a.Suit is graterthan b.Suit so return a.Suit.
			/// Then I am compare card a.Suit to card b.Suit, If b.Suit is graterthan a.Suit so return b.Suit.
			/// Then I am compare card a.Value to card b.Value, If a.Value is graterthan b.Value so return a.Value.
			/// Then I am compare card a.Value to card b.Suit, If a.Value is graterthan b.Value so return b.Value.
			/// </summary>
			if (a.Suit > b.Suit)
			{
				return 1;
			}
			if (a.Suit < b.Suit)
			{
				return -1;
			}
			if (a.Value > b.Value)
			{
				return 1;
			}
			if (a.Value < b.Value)
			{
				return -1;
			}
			return 0;
		}
	}
}
