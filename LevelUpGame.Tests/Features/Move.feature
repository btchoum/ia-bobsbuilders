Feature: Move
![Gamer](./data-.png)
    I want to move a character a direction on a map

@acceptance 
Scenario Outline: Move
    Moving the character increments its move count and adjusts its position.

    Given the characternario Outline: Set c's starting position <startX> <startY>
    And the character's move count is <startMoves>
    When the character inputs a <direction>
    Then the Game sets the character's newPosition to <endX> <endY>
    And the game increments the move count to <endMoves>
    Examples: 

        | startX | startY | startMoves | direction | endX | endY | endMoves
        | 0      | 0      | 0          | E         | 1    | 0    | 1
        | 6      | 2      | 6          | S         | 6    | 3    | 7
        | 4      | 3      | 2          | W         | 3    | 3    | 3
        | 5      | 0      | 3          | N         | 5    | 0    | 4 
        | 9      | 9      | 12         | E         | 9    | 9    | 13