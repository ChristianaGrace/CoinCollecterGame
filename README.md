# CoinCollecterGame
Developed using Unity as the environment. Coin Hunter is a 2D platform adventure game where the player navigates through a tile map collecting coins while avoiding various hazards and enemies to earn points. The game is targeted for individuals from the age of 8, offering easier controls and a simple script and menus.

# Game Mechanics Brief
1.	Health Bar
-Menu area allows the user to start a new game 
-Shows the user the last high score reached -Displays the game level that the player is currently playing on

1.	Player Controls 

- Arrow keys for movement. Up, down, left, forwards and right
-Space bar for allowing the user to jump

2.	Collectibles 

-Coins: each coin that is collected adds a point to the player’s score

3.	Hazards 

Green Capsule – Colliding with a green capsule causes a player to lose a life 
Slopes/Hills – colliding with a slope causes user to move forward
Score point – once a players’ score hits a zero from multiple enemy collisions, they are destroyed 

5.Lives

A player has a full life and once their life and health are on 0 the game ends 
The lives can increase when a player collides/ collects a red gem.

Levels 

-Each level consists of platforms, obstacles, coins, gems and hazards. Levels increase in difficulty as the player progresses introducing more hazards and the game becomes progressively difficult and faster. 
As the levels also progresses it's difficult for a player to find a red gem to increase life span

-The game has 3 levels that a player can go through. 
-The first level is Easy which means it has much less hazards 
-The second level is Medium which means that the game is fast and a more hazards 
-The third level is Difficult which means that the game is faster, and hazards are increased 


UI Elements;

-Score display – Shows the players’ current score in the game.
-Health bar display – Shows the players’ current number of lives in the game.
-Level indicator – Indicates the current level that the player is on.



# 	Targeted platforms

○	Initially developed for PC (Windows, macOS, Linux)
○	Potential for mobile game portability in future systems updates and upgrades.

# 	Targeted users 

-This game is specifically designed to appeal towards users aged between the ages 8-12 years.
-Potential for the game to appeal to a demographic of casual gamers who enjoy games with simple mechanics and game plays.

# Game Objects
<Object 1>
○	Player 
■	Player capsule / sprite 
■	Player Animations

➢	<Object 2>
○	Tile map
■	Green terrain 
■	Slopes and holes 

➢	<Object 3-Alternative>
○	Maze 
■	10 x10 maze covering the plane terrain
■	Grass/hedge material

➢	<Object 4>
○	Enemy 
■	Enemy sprite / capsule 
■	Damage Script
■	Etc.

➢	<Object 5-Aternative>
○	Treasure chest 

■	Wooden object
■	Blue gems 
■	Red gems 
➢	<Object 6>
○	Coins   
Yellow 
Object Animation

Assets Needed
➢	2D
○	TileMap

○	Textures
■	Environment Textures
■	Heightmap data

○	Character List
■	Player
■	Cactus (Enemy)

○	Environmental Art Lists
■	Maze 
■	Red gems
■	Blue gem
■	Slopes 




# Sound
○	Sound List (Player)
■	Character Movement Sound List
■	Character Hit / Collision Sound list
■	Character on Injured / Death sound list
■	Game start Sound list
■	Game finished Sound list


# 	Animation
○	Environment Animations 
○	Character Animations 
■	Player
●	Run, Idle and Jump
■	Enemy
●	Run, Idle, Jump
 

