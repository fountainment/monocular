using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monocle;
using System;
using System.Collections.Generic;

namespace MonocularTemplate
{
    public class MonocularTemplate : Engine
    {
        public MonocularTemplate() : base(1024, 768, 1024, 768, "Monocular Template", false)
        {
            ClearColor = Color.Black;
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            // Load content here, like atlas and effect
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();

            // Unload content here, like render target dispose
        }

        protected override void Initialize()
        {
            base.Initialize();

            // Window
            Window.AllowUserResizing = false;

            // Scene
            // Scene scene = new TemplateScene();
            // Engine.Scene = scene;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Game level update
        }
    }
}
