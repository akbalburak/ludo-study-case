# Ludo Study Case
## Description
This is a demo to demonstrate how addressable and bus systems are used.
Project start with a loading screen and load all the required models to play the game.
Player roll a dice and then play their pawn on playground as much as the number of dice.
## Technologies
### Addressables
Normally, all the prefabs referenced in the scene are loaded that causes memory usage and high loading times.
Addressables objects are loaded asynchronisly without locking the main thread when they are needed.
Its also possible to laod all the addressable objects from a remote server.
### Bus Systems
Bus Systems are used to reduce the dependency between classes.
Objects are not connect eachother directly but they listen and call the bus systems.
### Random API
There is a class which calls an api to get random dice numbers in the project.
Result parsed to int and stored in a list to return a number when the dice rolled.

## Supports
Windows
Android
iOS

## Resources
Game resources are only used for this demo.
