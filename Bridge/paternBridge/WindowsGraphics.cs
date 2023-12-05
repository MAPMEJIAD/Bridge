namespace paternBridge;

public class WindowsGraphics : IGraphicsElementImplementation
{
    private int _width = 5;
    private int _height = 1;

    public void DrawButton(string text)
    {
        Console.WriteLine("Windows TextField");
        var width = Math.Max(_width, text.Length);
        
        var horizontalLine = new string('-', width + 2);
        
        for (int i = 0; i < _height; i++)
        {
            Console.WriteLine($"| {text.PadLeft(width)} |");
        }
        
    }

    public void DrawTextField(string text)
    {
        Console.WriteLine("Windows TextField");
        var width = Math.Max(_width, text.Length);
        
        var horizontalLine = new string('#', width + 2);
        
        Console.WriteLine("+" + horizontalLine + "+");
        
        for (int i = 0; i < _height; i++)
        {
            Console.WriteLine($"# {text.PadLeft(width)} #");
        }
        
        Console.WriteLine("+" + horizontalLine + "+");
    }

    public void SetSize(int width, int height)
    {
        _width = width;
        _height = height;
    }
}