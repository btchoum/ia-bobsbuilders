using System;
using levelup;

namespace DotNetExample.Tests.Steps
{
    public interface IMap
    {
        string name {get; set;}
        int xLimit {get; set;}
        int yLimit {get; set;}

        void calculatePosition(GameController.Position pos, string dir) 
        validatePosition();
    
    }

    public class FakeMap : IMap
    {
        string name {get; set;}
        int xLimit {get; set;}
        int yLimit {get; set;}

        void calculatePosition(GameController.Position pos, string dir) {}
        validatePosition(); 

    }


}