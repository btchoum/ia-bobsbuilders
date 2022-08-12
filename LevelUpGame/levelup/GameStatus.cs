namespace levelup
{
    public record struct GameStatus(
        // TODO: Add other status data
        string CharacterName,
        Position Position,
        int MoveCount
    );
}