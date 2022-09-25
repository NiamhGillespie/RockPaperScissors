#include <stdio.h>
#include <time.h>
#include <math.h>
#include <stdlib.h>
#include <ctype.h>

void results(int points, char* username);
int playGame(char userMove, char computerMove);
char userPlay();
char computerPlay();
char * createUsername();

int main()
{
	
	printf("Welcome to rock, paper, scissors with C!\n\n");

	char* username = createUsername();
	char userMove = userPlay();
	char computerMove = computerPlay();

	int points = playGame(userMove, computerMove);
	results(points, username);
	
	return 0;
}

int playGame(char userMove, char computerMove) 
{
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

void results(int points, char* username) 
{
	if (points == 0) {
		printf("\nAlas it was a draw\n\n");
	} else if (points == 1) {
		printf("\nWhoop whoop you won %s!\n\n", username);
	} else if (points == -1) {
		printf("\nBoo you lost %s :(\n\n", username);
	} else {
		printf("\nThere seems to have been a mistake somewhere\n\n");
	}
}

char userPlay() 
{
	static char userChoice;
	printf("\nPlease enter one of the following options:  \n");
	printf("R for rock, P for paper, S for scissors and E for exit:  ");
	scanf("\n%c", &userChoice);
	
	if (toupper(userChoice) == 'R') {
		return 'r';
	} else if (toupper(userChoice) == 'P') {
		return 'p';
	} else if (toupper(userChoice) == 'S') {
		return 's';
	} else if (toupper(userChoice) == 'E') {
		printf("\nGoodbye...\n");
		exit(0);
	} else {
		printf("\nyou didn't enter any of the options provided, im very sad :(\n\n");
		return userPlay();
	}
	return 'h';
}
char computerPlay() 
{
	//this creates a random number between 1 and 3
	srand(time(NULL));
	int randomNumber = rand() % 3 + 1;
	
	char compMove;
	if (randomNumber == 1) {
		printf("\nThe computer played rock\n");
		compMove = 'r';
	} else if (randomNumber == 2) {
		printf("\nThe computer played paper\n");
		compMove = 'p';
	} else if (randomNumber == 3) {
		printf("\nThe computer played scissors\n");
		compMove = 's';
	} else {
		compMove = 'e';
		printf("\nerror has occurred!\n");
	}
	return compMove;
}

char * createUsername()
{
	// probably better ways to do this than using static
	// look this up :)
	static char username[20];
	printf("Please enter your username: \n");
	scanf("%s", username);
	
	return username;
	
}
