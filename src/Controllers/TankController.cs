using Godot;
using ZapTank.World.Entities.Tanks;

namespace ZapTank.Controllers;

/// <summary>
/// Responsible for providing inputs to a given tank. Records the last input state of the given tank.
/// </summary>
public abstract partial class TankController:Node
{
    public Vector2 LookDirection { get; protected set; }
    public Vector2 MoveDirection { get; protected set; }
    public bool FireInput { get; protected set; }

    [Export] protected TankBase Parent;

    // TODO Move this to networked TC.
    /// <summary>
    /// Updates input properties when the network sends something.
    /// </summary>
    public abstract void NetworkUpdateInputStates();
}