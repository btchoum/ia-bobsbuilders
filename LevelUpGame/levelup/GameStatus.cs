namespace levelup
{
    public record struct GameStatus(
        // TODO: Add other status data
        string characterName,
        Position Position,
        int MoveCount
    );
}