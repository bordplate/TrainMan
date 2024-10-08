using PracManCore.Scripting.UI;

namespace PracManMac.TrainerUI;

public class Row: Container {
    public Row(IWindow window) : base(window) {
        Window = window;
        
        TranslatesAutoresizingMaskIntoConstraints = false;
        Orientation = NSUserInterfaceLayoutOrientation.Horizontal;
        Distribution = NSStackViewDistribution.FillEqually;
    }

    public override void ConstrainElement(NSView element) {
        
    }
}