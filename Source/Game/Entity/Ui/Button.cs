using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Button : Ui
    {
        public Button(int ID, string NAME) : base(ID, NAME)
        {

        }

        public override void Update()
        {
            base.Update();

            sprite.UpdatePos(pos);
            sprite.UpdateScale(0);

            if (Helper.AreColliding(new Vector2(World.cursor.pos.X - 4, World.cursor.pos.Y - 4), World.cursor.dims, this.pos, this.dims))
            {

                sprite.UpdateScale(0.4f);

                if (Helper.mouse.LeftClick())
                {
                    sprite.UpdateScale(0);
                    OnClick();
                }
            }
        }

        public override Button GetEntity()
        {
            return new Button(id, name);
        }

        public void OnClick()
        {
        }
    }
}
