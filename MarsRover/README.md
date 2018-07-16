# MarsRover

#### Getting Started
- To begin, browse to a valid input file and select the Start button.

##### Input File Format:
- The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0, 0.
- The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. 
  - The first line gives the rover's starting position, and the second line is a series of instructions telling the rover how to explore the plateau.
  - The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation (N for north, S for south, E for east and W for west).

##### Example Input File
````
5 5
1 2 N 
LMLMLMLMM 
3 3 E
MMRMMRMRRM
````
This input file has a square plateau of 5x5 in size.
The first Rover is initially at { 1, 2 } facing North.
The path of the first rover is {Left, Move, Left, Move, Left, Move, Left, Move, Move} 
 
The second Rover is initially at { 3, 3 } facing East.
The path of the second rover is {Move, Move, Right, Move, Move, Right, Move, Right, Right, Move }
