using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CodenamedEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        public World world;
        public Game1()
        {


            _graphics = new GraphicsDeviceManager(this);
            _graphics.IsFullScreen = false;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;



        }


        protected override void Initialize()
        {
            Helper.screenWidth = _graphics.PreferredBackBufferWidth = 1280;
            Helper.screenHeight = _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();



            base.Initialize();
        }

        protected override void LoadContent()
        {


            Helper.content = this.Content;
            Helper.spriteBatch = new SpriteBatch(GraphicsDevice);


            world = new World();

            Helper.keyboard = new ShibKeyboard();
            Helper.mouse = new ShibMouse();



        }
        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed )
                Exit();
            Helper.gameTime = gameTime;

            Helper.keyboard.Update();
            Helper.mouse.Update();

            Helper.isActive = this.IsActive;

            world.Update();

            Helper.keyboard.UpdateOld();
            Helper.mouse.UpdateOld();

            base.Update(gameTime);
        }






        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Helper.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);

            world.Draw();

            Helper.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}