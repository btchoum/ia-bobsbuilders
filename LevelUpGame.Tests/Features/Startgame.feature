Feature: Startgame
![Gamer](./gamerErin.png)
    I want to start the game

@acceptance 
Scenario Outline: Start the Game
    This will start the game and creates the map and sets the Character starting position.

    Given the character is created
    When the player starts the game
    Then the Game creates the map and sets the character position to <characterX> <characterY>
    Examples:

        | startX | startY |  characterX | characterY |
        | 8      | 4      |  8          | 4          |
        | 4      | 3      |  4          | 3          |