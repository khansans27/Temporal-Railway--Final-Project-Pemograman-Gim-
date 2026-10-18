using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace Temporal_Railway;

public class Game1 : Core
{

// The MonoGame Logo texture
private Texture2D _logo;
    public Game1()  :base("Temporal Railway", 1280,720,false)
    {
        
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        _logo = Content.Load<Texture2D>("Images/logo");
        base.LoadContent();    
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {

        /// Note : The order do MATTER!!!!!!!!!
    
        // Changes The Background color
        GraphicsDevice.Clear(Color.CadetBlue);

        // Begin the sprite batch to prepare for rendering.
        SpriteBatch.Begin();

        // Draw the logo texture
        SpriteBatch.Draw(
        _logo,          // texture
        new Vector2(    // position
            Window.ClientBounds.Width,
            Window.ClientBounds.Height) * 0.5f, //0.5 is center
            null, //Source Rectangle
            Color.White,     // color
            0.0f, //ROTATE
            new Vector2(
            _logo.Width, 
            _logo.Height) * 0.5f, /// Origin/Anchor. Default scaling to upper-left
            0.0f, //Scale
            SpriteEffects.None, //effect
            0.0f //Layer Depth
    );

        // Always end the sprite batch when finished.
        SpriteBatch.End();
        

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
