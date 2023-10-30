# rock_paper_scissors

import random

possible_computer_actions = ["rock", "paper", "scissors"]
computer_actions = random.choice(possible_computer_actions)


user_action = input("Choose Rock, Paper or Scissors? ")

print("You chose {}, and the computer chose {}. Lets see who wins...".format(user_action, computer_actions))

if user_action == computer_actions:
    print("You've both tied! \nTry again")

elif user_action == "rock" and computer_actions == "scissors":
    print("Rock smashes scissors.\nYOU WIN!")

elif user_action == "paper" and computer_actions == "rock":
    print("Paper wraps around rock and suffocates it. \nYOU WIN!")

elif user_action == "scissors" and computer_actions == "paper":
    print("Scissors shreds paper to pieces. \nYOU WIN!")

else:
    print("You lost!")
