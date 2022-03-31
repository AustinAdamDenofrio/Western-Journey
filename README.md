# Oregon-Trail-CS-
Oregon trail repo is a console app styled rpg game that the player gets to create their character than purchase items they will need on their journey west.
The player will enter the start town then be asked to name their character. After naming their character they will then be able to shop for supplies
for their journey. After they have gathered all they want from the store they start their journey west and almost immedietly encounter issues.

The game contains several C# features

4 methods: 
Some of them not yet implimented into the game 
 -EnemyDamage    is the method that calculates enemy damage at random
 -PlayerDamage   is the method that calculates the players damage and critical strike damage as well as regulates the odds of critiacal strikes
 -Store          is the method that dives the player into a store menu that allows them to purchase items  
 -PlayerReview   This method allows the player to review the game then stores their answers in a json file

Features:
-Masterloops  
     The loops are in the Store and PlayerReview methods. They run to ensure the player chooses a valid selection in the menus.
-Additional class that inherits properties from it's parent
     The Bear class inherits from the enemy class, taking on all the characteristics exept has higher health.
-




 Necessary Add-ons:
Newton.Json package is necessary for the program to run properly
