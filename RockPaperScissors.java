import java.util.Random;
import java.util.Scanner;

public class RockPaperScissors {

	private String username;
	
	public static void main(String args[]) { 
		RockPaperScissors rockPaperScissors = new RockPaperScissors();
		System.out.println("Welcome to rock, paper, scissors!");
		rockPaperScissors.createUsername();
		String userPlay = rockPaperScissors.userPlay();
		String computerPlay = rockPaperScissors.computerPlay();
		
		int points = rockPaperScissors.playGame(userPlay, computerPlay);
		rockPaperScissors.results(points);
	}
	

	public int playGame(String userPlay, String computerPlay) {
		
		switch (userPlay) {
        case "r":
        	if (computerPlay.equals("s")) {
        		return 1;
        	} else if (computerPlay.equals("p")) {
        		return -1;
        	} else {
        		return 0;
        	}
        case "p":
        	if (computerPlay.equals("r")) {
        		return 1;
        	} else if (computerPlay.equals("s")) {
        		return -1;
        	} else {
        		return 0;
        	}
        case "s":
        	if (computerPlay.equals("p")) {
        		return 1;
        	} else if (computerPlay.equals("r")) {
        		return -1;
        	} else {
        		return 0;
        	}	
        }
		return 2;
	}
	
	private void results(int points) {
		if (points == 0) {
			System.out.println("Alas it was a draw");
		}else if (points == 1) {
			System.out.println("Whoop whoop you won " + username + "!");
		}else if (points == -1) {
			System.out.println("Boo you lost " + username + " :(");
		} else {
			System.out.println("There seems to have been a mistake somewhere");
		}
	}
	
	private String userPlay() {
		System.out.println("Please enter one of the following options:");
		System.out.println("R for rock, P for paper, S for scissors or E for exit");
		Scanner userInput = new Scanner(System.in);
		String userChoice = userInput.nextLine();
		
		if (userChoice.toUpperCase().equals("R")) {
			return "r";
		} else if (userChoice.toUpperCase().equals("P")) {
			return "p";
		} else if (userChoice.toUpperCase().equals("S")) {
			return "s";
		} else if (userChoice.toUpperCase().equals("E")) {
			System.out.println("Goodbye " + username + "...");
			System.exit(0);
			return "exited";
		} else {
			System.out.println("You didn't enter one of the options, I'm very dissapointed in you " + username);
			return userPlay();
		}
		
		
	}
	
	private String computerPlay() {
		Random random = new Random();
		int choice = random.nextInt(3) + 1;

		if (choice == 1) {
			System.out.println("The computer played rock");
			return "r";
		} else if (choice == 2) {
			System.out.println("The computer played paper");
			return "p";
		} else {
			System.out.println("The computer played scissors");
			return "s";
		}
	}

	public void createUsername() {
		System.out.println("Please enter a username :)");
		Scanner userInput = new Scanner(System.in); 
		this.username = userInput.nextLine();
	}
	
	

}
