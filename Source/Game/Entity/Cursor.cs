using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Cursor : Entity
    {
        public Cursor(int ID, string NAME) : base(ID, NAME)
        {
            sprite = new Sprite(header + name, pos, dims);
            dims = new Vector2(8, 8);
        }

        public override void Update()
        {
            pos = Helper.mouse.newMousePos / Helper.spriteScale;




            base.Update();

        }

        public override Cursor GetEntity()
        {
            return new Cursor(id, name);
        }
    }
}
