using Chickensoft.AutoInject;
using Godot;
using SuperNodes.Types;

namespace DITest;

[GlobalClass]
[SuperNode(typeof(Provider))]
public partial class FruitTree : Node, IProvide<bool>, IProvide<string>
{
    public override partial void _Notification(int what);

    private bool CoolTree => true;
    private string TreeName => "Viridescent tree";

    bool IProvide<bool>.Value() => CoolTree;
    string IProvide<string>.Value() => TreeName;

    public override void _Ready()
    {
        base._Ready();

        AddChild(new Orange());

        Provide();
    }
}