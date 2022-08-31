namespace SnakeGame;

public readonly struct Pixel
{
    private const char PixelChar = '█';
    public Pixel(int x, int y, ConsoleColor color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public int X { get; }
    public int Y { get; }
    public ConsoleColor Color { get; }

    public void Draw()
    {
        Console.ForegroundColor = Color;
        for (int x = 0; x < GlobalStorage.PixelSize; x++)
        {
            for (int y = 0; y < GlobalStorage.PixelSize; y++)
            {
                Console.SetCursorPosition(X * GlobalStorage.PixelSize + x, Y * GlobalStorage.PixelSize + y);
                Console.Write(PixelChar);
            }
        }
    }

    public void Clear()
    {
        for (int x = 0; x < GlobalStorage.PixelSize; x++)
        {
            for (int y = 0; y < GlobalStorage.PixelSize; y++)
            {
                Console.SetCursorPosition(X * GlobalStorage.PixelSize + x, Y * GlobalStorage.PixelSize + y);
                Console.Write(' ');
            }
        }
    }
}