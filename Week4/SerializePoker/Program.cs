using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
namespace SerializePoker;

[Serializable]
public class Card
{
	public string Rank { get; set; }
	public string Suit { get; set; }

	public Card(string rank, string suit)
	{
		Rank = rank;
		Suit = suit;
	}
}

[Serializable]
public class Deck
{
	public List<Card> Cards { get; set; }

	public Deck()
	{
		Cards = new List<Card>();
		// Initialize the deck with cards (e.g., 52 cards for a standard deck)
	}

	// Add methods to shuffle, deal cards, etc.
}

[Serializable]
public class Hand
{
	public List<Card> Cards { get; set; }

	public Hand()
	{
		Cards = new List<Card>();
	}
}

[Serializable]
public class Player
{
	public string Name { get; set; }
	public int Chips { get; set; }
	public Hand Hand { get; set; }

	public Player(string name, int chips)
	{
		Name = name;
		Chips = chips;
		Hand = new Hand();
	}
}

[Serializable]
public class PokerGame
{
	public List<Player> Players { get; set; }
	public Deck Deck { get; set; }

	public PokerGame()
	{
		Players = new List<Player>();
		Deck = new Deck();
	}

	public void AddPlayer(Player player)
	{
		Players.Add(player);
	}



	// Other methods to manage the game (betting, dealing, etc.)
}

public static class PokerGameSerializer
{
	public static void SerializeGame(string filePath, object gameData)
	{
		DataContractSerializer serializer = new DataContractSerializer(gameData.GetType());
		using (XmlWriter writer = XmlWriter.Create(filePath))
		{
			serializer.WriteObject(writer, gameData);
		}
	}

	public static T DeserializeGame<T>(string filePath)
	{
		DataContractSerializer serializer = new DataContractSerializer(typeof(T));
		using (XmlReader reader = XmlReader.Create(filePath))
		{
			return (T)serializer.ReadObject(reader);
		}
	}
}

public class Program
{
	static void Main()
	{
		// Create a poker game and players
		PokerGame pokerGame = new PokerGame();
		Player player1 = new Player("John", 1000);
		Player player2 = new Player("Alice", 1500);
		pokerGame.AddPlayer(player1);
		pokerGame.AddPlayer(player2);

		// Save the game
		PokerGameSerializer.SerializeGame("saved_game.xml", pokerGame);

		// Load a saved game
		PokerGame loadedGame = PokerGameSerializer.DeserializeGame<PokerGame>("saved_game.xml");

		// Now you can continue the game with the loaded state.
	}
}
