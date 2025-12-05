using Godot;
using ZapTank.World.Entities.Tanks;

namespace ZapTank.Controllers;

/// <summary>
/// Responsible for controlling a given tank.
/// </summary>
public abstract partial class TankController:Node
{
    [Export] protected TankBase Parent;

    /// <summary>
    /// Updates velocity every physics tick.
    /// </summary>
    protected abstract void UpdateVelocity();
    
    /// <summary>
    /// Updates rotation every physics tick.
    /// </summary>
    protected abstract void UpdateRotation();

    public override void _PhysicsProcess(double delta)
    {
        UpdateRotation();
        UpdateVelocity();
    }
}