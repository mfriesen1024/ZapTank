using Godot;

namespace ZapTank.Controllers;

/// <summary>
/// Used by a client to provide inputs to their tank.
/// </summary>
public partial class PlayerController:TankController
{
    // The player should refuse any attempts to forcibly set its input states.
    public override void NetworkUpdateInputStates()
    {
        
    }

    public override void _Input(InputEvent input)
    {
        
    }
}