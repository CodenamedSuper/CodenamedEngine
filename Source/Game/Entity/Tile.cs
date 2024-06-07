using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Tile : Entity
    {
        public Tile(int ID, string NAME) : base(ID, NAME)
        {
            sprite = new Sprite(name, Vector2.Zero, dims);
        }

        public override Tile GetEntity()
        {
            return new Tile(id, name);

        }

    }
}
