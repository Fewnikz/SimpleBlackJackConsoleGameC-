using System;
namespace BlackJackSimpleConsoleGame;
/* Definition of Done
The application builds without errors.
The application runs without crashing.
All acceptance criteria are met.
*/

/*
 * US-08
*/

class Game
{
    static void Main(string[] args)
    {
        GameRunner gameRunner = new GameRunner();
        gameRunner.RunGame();
    }
}

/*
 This makes the code compile faster "trust!"
    Gotta go fast!
   ░░░░░░░░▀▀▀██████▄▄▄░░░░░░░░░░░░
   ░░░░░░▄▄▄▄▄░░█████████▄░░░░░░░░░
   ░░░░░▀▀▀▀█████▌░▀▐▄░▀▐█░░░░░░░░░
   ░░░▀▀█████▄▄░▀██████▄██░░░░░░░░░
   ░░░▀▄▄▄▄▄░░▀▀█▄▀█════█▀░░░░░░░░░
   ░░░░░░░░▀▀▀▄░░▀▀███░▀░░░░░░▄▄░░░
   ░░░░░▄███▀▀██▄████████▄░▄▀▀▀██▌░
   ░░░██▀▄▄▄██▀▄███▀░▀▀████░░░░░▀█▄
   ▄▀▀▀▄██▄▀▀▌████▒▒▒▒▒▒███░░░░▌▄▄▀
   ▌░░░░▐▀████▐███▒▒▒▒▒▐██▌░░░░░░░░
   ▀▄░░▄▀░░░▀▀████▒▒▒▒▄██▀░░░░░░░░░
   ░░▀▀░░░░░░▀▀█████████▀░░░░░░░░░░
   ░██████╗░█████╗░███╗░░██╗██╗░█████╗░
   ██╔════╝██╔══██╗████╗░██║██║██╔══██╗
   ╚█████╗░███████║██╔██╗██║██║██║░░╚═╝
   ░╚═══██╗██╔══██║██║╚████║██║██║░░██╗
   ██████╔╝██║░░██║██║░╚███║██║╚█████╔╝
   ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚════╝░
*/