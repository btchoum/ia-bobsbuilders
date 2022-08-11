Feature: Move
![Gamer](./data-.png)
    I want to move a character a direction on a map

@acceptance 
Scenario Outline: Move
    Moving the character increments its move count and adjusts its position.

    Given the character's starting position is <startX> <startY>
    And the character's move count is <startMoves>
    When the character inputs a <direction>
    Then the Game sets the character's newPosition to <endX> <endY>
    And the game increments the move count to <endMoves>
    Examples: 

        | startX | startY | startMoves | direction | endX | endY | endMoves
        | 0      | 0      | 0          | EAST      | 1    | 0    | 1
        | 6      | 2      | 6          | SOUTH     | 6    | 3    | 7
        | 4      | 3      | 2          | WEST      | 3    | 3    | 3
        | 5      | 0      | 3          | NORTH     | 5    | 0    | 4 
        | 9      | 9      | 12         | EAST      | 9    | 9    | 13