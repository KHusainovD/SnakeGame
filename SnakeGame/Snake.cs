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
    }
    public Pixel Head { get; private set; }
    public Queue<Pixel> Body { get; } = new Queue<Pixel>();
}