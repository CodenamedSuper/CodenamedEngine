using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Ui : Entity
    {
        public new string header = "Ui\\";
        public Ui(int ID, string NAME) : base(ID, NAME)
        {
            sprite = new Sprite(header + name, pos, dims);

        }

        public override Ui GetEntity()
        {
            return new Ui(id, name);
        }

        public override void Draw()
        {
            sprite.Draw(pos + Helper.screenOffset, Vector2.Zero);
        }
    }
}
