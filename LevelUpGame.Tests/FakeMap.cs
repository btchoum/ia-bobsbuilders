using levelup;

namespace DotNetExample.Tests
{
    public class FakeMap : Map
    {
       public string? Name {get; set;}

       public Position CalculatePosition(Position pos, string dir) 
       {
            return new Position(0, 0); 
       }
    }
}