namespace paternBridge;

public class GraphicsElement
{
    private IGraphicsElementImplementation _graphicsElementImplementation;

    public GraphicsElement(IGraphicsElementImplementation graphicsElementImplementation)
    {
        _graphicsElementImplementation = graphicsElementImplementation;
    }
    
    public IGraphicsElementImplementation GraphicsElementImplementation
    {
        set => _graphicsElementImplementation = value;
    }
    
    public virtual void DrawButton(string text)
    {
        _graphicsElementImplementation.DrawButton(text);
    }
    
    public virtual void DrawTextField(string text)
    {
        _graphicsElementImplementation.DrawTextField(text);
    }
    public virtual void SetSize(int width,int height)
    {
        _graphicsElementImplementation.SetSize(width,height);
    }
}