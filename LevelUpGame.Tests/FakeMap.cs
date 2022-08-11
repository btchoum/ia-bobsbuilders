using System;
using levelup;

namespace DotNetExample.Tests.Steps
{

    public class FakeMap : IMap
    {
       public string name {get; set;}
       public int xLimit {get; set;}
       public int yLimit {get; set;}

       public void calculatePosition(GameController.Position pos, string dir) {}
  

    }


}