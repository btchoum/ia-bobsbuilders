using levelup;

namespace DotNetExample.Tests.Steps
{
    public class FakeMap : Map
    {
       public string name {get; set;}

       public Position calculatePosition(Position pos, string dir) 
       {
            return new Position(0, 0); 
       }
    }
}