namespace levelup
{
    public interface ICharacter
    {
        string? Name {get; set;}
        int MoveCount {get; set;}
        GameController.Position CurrentPosition {get; set;}

        void Move( GameController.DIRECTION direction, IMap map);
        
    }
}
