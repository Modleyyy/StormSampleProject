namespace MyGame;

#nullable disable
public class MyGame : Game
{
    Player player;

    public override void OnLoad()
    {
        // TODO: Initialize and load stuff here. eg:

        screenColor = Color.CornflowerBlue;

        // Load the player and set it's position to be at the center of the screen.
        player = new Player(new Vector2(400, 300));
    }

    public override void OnUpdate(double deltaTime)
    {
        // TODO: Update stuff here.

        // DISCLAIMER: This method is called after updating EVERYTHING else. You don't
        // need to update GameObjects and their Components, they're automatically
        // updated.
    }

    public override void OnDraw(Graphics graphics)
    {
        // TODO: Draw your stuff here.
    
        // DISCLAIMER: This method is called after drawing EVERYTHING else. So GameObjects
        // will have their OnDraw method called first, then this is called. So you could
        // use this for drawing stuff like debug, UI, screen shaders, ect...
    }
}