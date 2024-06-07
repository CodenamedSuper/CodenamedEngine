using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Entity
    {

        public string header = "";

        public int id;
        public string name;

        public Vector2 pos;
        public Vector2 dims;

        public Sprite sprite;

        public Entity(int ID, string NAME) 
        {
            dims = new Vector2(16, 16);
            name = NAME;
            id = ID;

        }

        public virtual void Update()
        {
            sprite.UpdatePos(pos);

        }

        public void Move(Vector2 ADDITION)
        {
            pos += Helper.Grid(ADDITION);
        }

        public virtual Entity GetEntity()
        {
            return new Entity(id, name);
        }

        public virtual void Draw()
        {
            sprite.Draw();
            
        }

    }
}
