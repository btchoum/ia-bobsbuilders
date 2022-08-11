using System;
using levelup;

namespace DotNetExample.Tests.Steps
{

    public class FakeMap : IMap
    {
       public string name {get; set;}

       public Position calculatePosition(Position pos, string dir) {}
  

    }


}