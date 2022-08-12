using levelup;

namespace DotNetExample.Tests
{
    public class FakeMap : Map
    {
        private Position _position;

        public string? Name { get; set; }

        public Position CalculatePosition(Position pos, string dir)
        {
            return _position;
        }

        public void CalculatePositionShouldReturn(Position position)
        {
            _position = position;
        }
    }
}