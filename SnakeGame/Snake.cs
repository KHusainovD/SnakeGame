namespace SnakeGame;

public class Snake
{
    public Pixel Head { get; private set; }
    public Queue<Pixel> Body { get; set; }
}