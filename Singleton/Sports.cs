using System;
namespace Singleton
{
public class Game{
	public string game{private set;get;}
	public int year{ private set; get; }
	public string tournament{ private set; get; }
	public string winner{ private set; get; }
	public Game(string tournament,string game,int year,string winner){
		this.game=game;
		this.tournament=tournament;
		this.year=year;
		this.winner=winner;
	}
}


public class Sports{
	private static Sports sports=null;
	private Sports(){
	}
	public static Sports init{
		get{
			if (sports == null)
				sports = new Sports();
			return sports;
		}
	}


	public void logGame(string game, int noOfPlayers, bool isWinner){
		Console.WriteLine(game+" Played By:"+noOfPlayers.ToString()+" Status:"+isWinner.ToString());
	}

	public void getGameStats(Game game){
		Console.WriteLine("Tournament: "+game.tournament + " Year: " + game.year.ToString() + 
		"\n Game: "+game.game+"\n Winner: " + game.winner);
	}
}
}