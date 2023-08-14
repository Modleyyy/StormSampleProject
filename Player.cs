namespace MyGame;

// Create a GameObject
public class Player : GameObject
{
    Sprite2D sprite;
    InputHandler input;

    //                                     " name ",              (position,    scale   ),             {  tags  }, visible
    public Player(Vector2 position) : base("Player", new Transform(position, Vector2.One), new string[]{"Player"}, true)
    {
        // TODO: Initialize some stuff you might need here, like initializing your
        // components. eg:

        // Create a Component.
        sprite = new("icon.ico", centered: true, pooled: false); // We can just use the icon for the sprite.
        AddComponent(sprite);

        input = new();
        AddComponent(input);
    }

    public override void OnUpdate(double deltaTime)
    {
        // TODO: Update stuff the player might need, like their position for example. eg:
        transform.position += input.GetVector(Keys.Right,Keys.Left , Keys.Down,Keys.Up).Normalized() * 5;
    }

    public override void OnDraw(Graphics graphics)
    {
        // TODO: Draw stuff. For example the actual sprite or a rectangle representing the
        // player's bounding box, ect... or even drawing a placeholder circle if you don't
        // have a sprite! eg:
        sprite.Draw(graphics);
    }
}