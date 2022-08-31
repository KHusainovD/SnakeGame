namespace SnakeGame;

public class Snake
{
    private readonly ConsoleColor _headColor;
    private readonly ConsoleColor _bodyColor;

    public Snake(int initialX,
        int initialY,
        ConsoleColor headColor,
        ConsoleColor bodyColor,
        int bodyLength = 3)
    {
        _headColor = headColor;
        _bodyColor = bodyColor;
        Head = new Pixel(initialX, initialY, _headColor);

        for (int i = bodyLength; i >= 0; i--)
        {
            Body.Enqueue(new Pixel(Head.X - i - 1, initialY, _bodyColor));
        }

        Draw();
    }

    public Pixel Head { get; private set; }
    public Queue<Pixel> Body { get; } = new Queue<Pixel>();

    public void Move(Direction direction)
    {
        Clear();

        Body.Enqueue(new Pixel(Head.X, Head.Y, _bodyColor));
        Body.Dequeue();

        Head = direction switch
        {
            Direction.Right => Head = new Pixel(Head.X + 1, Head.Y, _headColor),
            Direction.Left => Head = new Pixel(Head.X - 1, Head.Y, _headColor),
            Direction.Up => Head = new Pixel(Head.X, Head.Y - 1, _headColor),
            Direction.Down => Head = new Pixel(Head.X, Head.Y + 1, _headColor),
            _ => Head
        };

        Draw();
    }

    public void Draw()
    {
        Head.Draw();

        foreach (var pixel in Body)
        {
            pixel.Draw();
        }
    }

    public void Clear()
    {
        Head.Clear();

        foreach (var pixel in Body)
        {
            pixel.Clear();
        }
    }
}