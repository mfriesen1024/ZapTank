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

    /// <summary>
    /// Updates the given input fields when an input action is provided.
    /// </summary>
    protected abstract void UpdateInputStates(InputEvent input);
}