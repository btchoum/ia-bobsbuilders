namespace levelup
{
        public interface IMap
    {
        string name {get; set;}
        int xLimit {get; set;}
        int yLimit {get; set;}

        void calculatePosition(GameController.Position pos, string dir); 
    
    
    }
}