using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine { 
    public class Tiles
    {
        public static List<Tile> tiles = new List<Tile>();


        public Tiles()
        {
            tiles.Add(new Tile(0, "tile"));
        } 
    }
}
