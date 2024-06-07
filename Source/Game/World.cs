using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class World
    {
        public static List<Entity> entities = new List<Entity>();
        public static List<Text> texts = new List<Text>();

        public Uis uisList;
        public Tiles tilesList;

        public Tilemap tilemap;

        public static Cursor cursor;
        public static Stats stats;

        public World()
        {
            tilesList = new Tiles();
            uisList = new Uis();

            cursor = new Cursor(0, "cursor");
            stats = new Stats();


            tilemap = new Tilemap(240, new Vector2(20, 12));

            RegisterUis();
        }

        public void RegisterUis()
        {

        }

        public void Update()
        {
            tilemap.Update();

            foreach (Entity entity in entities.ToList<Entity>())
            {
                entity.Update(); 
            }
            foreach (Text text in texts.ToList<Text>())
            {
                
            }

            cursor.Update();
        }

        public static void AddTemplateEntity(int ID, Vector2 POS)
        {
            POS = Helper.Snap(POS);
            entities.Add(entities[ID].GetEntity());
            entities[entities.Count - 1].pos = new Vector2(POS.X, POS.Y);
        }

        public static void AddText(string TEXT, float SCALE, Vector2 POS)
        {
            POS = Helper.Snap(POS);
            texts.Add(new Text(TEXT, POS, 0, SCALE));
        }


        public static void OpenUi(int ID, Vector2 POS)
        {
            entities.Add(Uis.uis[ID].GetEntity());
            entities[entities.Count - 1].pos = new Vector2(POS.X, POS.Y);
        }

        public static void CloseUi(Ui UI)
        {
            foreach (Ui ui in entities.OfType<Ui>())
            {
                if(ui == UI)
                {
                    entities.Remove(ui);
                    break;
                }
            }
        }

        public static Vector2 Cords(Vector2 POS)
        {
            return new Vector2((int)Math.Floor(POS.X / (int)Helper.gridSize.Y), (int)Math.Floor(POS.Y / (int)Helper.gridSize.Y));
        }

        public static Entity At(Vector2 POS)
        {
            foreach (Entity entity in entities)
            {
                if(entity.pos == POS * Helper.gridSize)
                {
                    return entity;
                }
            }

            cursor.Draw();
            return null;
        } 

        public void Draw()
        {
            tilemap.Draw();
            foreach (Entity entity in entities)
            {
                entity.Draw();
            }
            foreach (Text text in texts.ToList<Text>())
            {
                text.Draw();
            }
        }
    }
}
