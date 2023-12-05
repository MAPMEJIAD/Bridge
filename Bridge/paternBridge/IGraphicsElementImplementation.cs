namespace paternBridge;

public interface IGraphicsElementImplementation
{
    void DrawButton(string text);
    void DrawTextField(string text);
    void SetSize(int width,int height);
}