using paternBridge;

var widows = new GraphicsElement(new WindowsGraphics());
var mac = new GraphicsElement(new MacGraphics());
widows.DrawButton("win button");
widows.DrawTextField("Win Text Field");

mac.DrawTextField("Mac Text Field");
mac.DrawButton("mac button");