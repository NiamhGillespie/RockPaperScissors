import random

def results(points, username):
	if points == 0:
		print("\nAlas it was a draw\n")
	elif points == 1:
		print("\nWhoop whoop you won " +  username + "!\n")
	elif points == -1:
		print("\nBoo you lost " + username + ":(\n")
	else:
		printf("\nThere seems to have been a mistake somewhere\n")


def playGame(userMove, computerMove):

	match userMove:
		case 'r':
			if computerMove == 's':
				return 1
			elif computerMove == 'p':
				return -1
			else:
				return 0;
		case 'p':
			if computerMove == 'r':
				return 1
			elif computerMove == 's':
				return -1
			else:
				return 0
		case 's':
			if computerMove == 'p':
				return 1
			elif computerMove == 'r':
				return -1
			else:
				return 0
	

def computerPlay():
	randomNumber = random.randint(1,3)
	
	if randomNumber == 1:
		print("The computer played rock")
		compMove = 'r'
	elif randomNumber == 2:
		print("The computer played paper")
		compMove = 'p'
	elif randomNumber == 3:
		print("The computer played scissors")
		compMove = 's'
	else:
		compMove = 'e'
		print("error has occurred!")
	return compMove;

def userPlay():

	print("\nPlease enter one of the following options:")
	userChoice = input("R for rock, P for paper, S for scissors and E for exit:  ")
	if userChoice.upper() == 'R':
		return 'r'
	elif userChoice.upper() == 'P':
		return 'p'
	elif userChoice.upper() == 'S':
		return 's'
	elif userChoice.upper() == 'E':
		print("\nGoodbye...")
		quit()
	else:
		print("you didn't enter any of the options provided, im very sad :(")
		return userPlay()


def createUsername():
	
	username = input("Please enter your username :\n")
	return username
	

if __name__ == "__main__":
	print("Welcome to rock, paper, scissors with Python!\n");

	username = createUsername()
	userMove = userPlay();
	computerMove = computerPlay();
	
	points = playGame(userMove, computerMove);
	results(points, username);



	
