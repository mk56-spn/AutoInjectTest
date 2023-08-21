using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

namespace DITest;

[SuperNode(typeof(Dependent))]
public partial class Orange : Node
{
    public override partial void _Notification(int what);

    [Dependency] private string TreeName => DependOn<string>();
    [Dependency] private bool CoolTree => DependOn<bool>();

    public void OnResolved()
    {
        GD.Print(CoolTree);
        GD.Print(TreeName);
    }
}