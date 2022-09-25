using System;
class RockPaperScissors {

  private string username;
  
  static void Main(string[] args)
  {
      Console.WriteLine("Welcome to rock, paper, scissors with C#\n");
      
      RockPaperScissors rockPaperScissors = new RockPaperScissors();
      rockPaperScissors.username = rockPaperScissors.createUsername();
      
      char userMove = rockPaperScissors.userPlay();

      char computerMove = rockPaperScissors.computerPlay();
      
      int points = rockPaperScissors.playGame(userMove, computerMove);
      rockPaperScissors.results(points);
  }
  
  
  int playGame(char userMove, char computerMove) {
	switch (userMove) {
	case 'r':
		if (computerMove == 's') {
			return 1;
		} else if (computerMove == 'p') {
			return -1;
		} else {
			return 0;
		}
	case 'p':
		if (computerMove == 'r') {
			return 1;
		} else if (computerMove == 's') {
			return -1;
		} else {
			return 0;
		}
	case 's':
		if (computerMove == 'p') {
			return 1;
		} else if (computerMove == 'r') {
			return -1;
		} else {
			return 0;
		}
	}
	return 2;
  }
  
  void results(int points) {
	if (points == 0) {
		Console.WriteLine("Alas it was a draw");
	} else if (points == 1) {
		Console.WriteLine("Whoop whoop you won " + username + "!");
	} else if (points == -1) {
		Console.WriteLine("Boo you lost " + username + " :(");
	} else {
		Console.WriteLine("There seems to have been a mistake somewhere");
	}
  }


  char userPlay() {
	
	Console.WriteLine("Please enter one of the following options:");
	Console.WriteLine("R for rock, P for paper, S for scissors and E for exit:  ");
	// substring here will only take the first character of the user
	// input so that this code can take a wider range of inputs
	// NEED TO LENGTH PROOF THIS 
	char userChoice = Convert.ToChar(Console.ReadLine().Substring(0, 1));
	
	if (char.ToUpper(userChoice) == 'R') {
		return 'r';
	} else if (char.ToUpper(userChoice) == 'P') {
		return 'p';
	} else if (char.ToUpper(userChoice) == 'S') {
		return 's';
	} else if (char.ToUpper(userChoice) == 'E') {
		Console.WriteLine("Goodbye...\n");
		Environment.Exit(0);
	} else {
		Console.WriteLine("you didn't enter any of the options provided, im very sad :(\n");
		return userPlay();
	}
	// this should never be reached?
	return 'n';
  }
  
  char computerPlay() {
	//this creates a random number between 1 and 3
	Random random = new Random();
	int randomNumber = random.Next(1, 4); 
	
	char compMove;
	if (randomNumber == 1) {
		Console.WriteLine("The computer played rock");
		compMove = 'r';
	} else if (randomNumber == 2) {
		Console.WriteLine("The computer played paper");
		compMove = 'p';
	} else if (randomNumber == 3) {
		Console.WriteLine("The computer played scissors");
		compMove = 's';
	} else {
		compMove = 'e';
		Console.WriteLine("error has occurred!\n");
	}
	return compMove;
  }

  
  string createUsername() {

	
	Console.WriteLine("Please enter your username:  ");
	string username = Console.ReadLine();
	
	return username;
  }
}
