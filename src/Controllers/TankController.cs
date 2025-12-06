using System;
using Godot;
using ZapTank.Core;
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

    /// <summary>
    /// Sends input stuff to the event system so we can do stuff with it.
    /// </summary>
    protected void SendInputUpdate()
    {
        EventSystem.InputUpdatePush?.Invoke(this);
    }
}