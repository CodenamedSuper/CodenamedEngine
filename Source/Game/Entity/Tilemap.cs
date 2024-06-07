using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Tilemap
    {
        public List<Tile> tiles = new List<Tile>();
        public Vector2 dims;

        public Tilemap(int COUNT, Vector2 DIMS)
        {
            dims = new Vector2(DIMS.X, DIMS.Y);

            int x = 0;
            int y = 0;
            for(int i = 0; i < COUNT; i ++)
            {
                tiles.Add(Tiles.tiles[0].GetEntity());


                tiles[i].pos = Helper.Grid(new Vector2(x, y));

                x++;
                if(x == dims.X)
                {
                    x = 0;
                    y++;
                }
            }

        }

        public virtual void Update()
        {
            foreach (Tile tile in tiles)
            { 

                tile.Update();
            }
        }

        public virtual void Draw()
        {
            foreach (Tile tile in tiles)
            {
                tile.Draw();
            }
        }
    }
}
