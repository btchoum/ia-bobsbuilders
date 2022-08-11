namespace levelup
{
        public interface IMap
    {
        string name {get;}

        Position calculatePosition(Position pos, string dir); 
    
    }
}