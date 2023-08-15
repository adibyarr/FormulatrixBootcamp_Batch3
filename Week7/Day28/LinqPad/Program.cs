using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerEvaluator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("masukkan number player: ");
			if(int.TryParse(Console.ReadLine(), out int numberOfPlayers))
			{
				List<Player> players = GeneratePlayers(numberOfPlayers);
				DealHands(players);
				foreach (var player in players)
				{
					Console.WriteLine($"Player {player.Name}: {string.Join(" ", player.Hand)}");
				}
			}
			else
			{
				Console.WriteLine("Invaliddd");
			}
		}

		static List<Player> GeneratePlayers(int count)
		{
			var players = new List<Player>();
			for (int i = 1; i <= count; i++)
			{
				Console.Write($"Masukkan nama dari player {i}: ");
				string playerName = Console.ReadLine();
				players.Add(new Player { Name = $"Player {i}" });
			}
			return players;
		}

		static void DealHands(List<Player> players)
		{
			var random = new Random();
			var suits = new char[] { 'H', 'D', 'S', 'C' };
			var values = new char[] { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };

			foreach (var player in players)
			{
				var hand = new List<string>();

				for (int j = 0; j < 5; j++)
				{
					var suit = suits[random.Next(suits.Length)];
					var value = values[random.Next(values.Length)];
					hand.Add($"{value}{suit}");
				}

				player.Hand = hand;
			}
		}
	}

	class Player
	{
		public string Name { get; set; }
		public List<string> Hand { get; set; }
	}
}
