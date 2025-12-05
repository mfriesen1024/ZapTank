using System;
using Godot;
using ZapTank.Controllers;
using ZapTank.Util;

namespace ZapTank.World.Entities.Tanks;

public abstract partial class TankBase:RigidBody2D
{
    protected bool IsDying;
    
    [Export] protected TankController Controller;
    
    // Hp
    [ExportGroup("Health")]
    [Export] protected HealthInfo HealthInfo;
    public int Health { get; protected set; }
    public virtual int MaxHealth { get => HealthInfo.MaxHealth; }
    protected int healingRate;
    int ticksSinceLastHeal;

    protected abstract void Fire();

    /// <summary>
    /// Called by the <c>TankController</c> to update movement variables. 
    /// </summary>
    /// <param name="targetVelocity">The relative direction to try to move in.</param>
    /// <param name="targetRotation">The relative direction to try to look at.</param>
    protected virtual void HandleMovement(Vector2 targetVelocity, Vector2 targetRotation)
    {
        //TODO: Implement speed and acceleration.
        LinearVelocity = targetVelocity;
        LookAt(GlobalPosition+targetRotation);
    }

    public override void _Ready()
    {
        base._Ready();
        
        Health = MaxHealth;
        healingRate = HealthInfo.HealingRate;
        ticksSinceLastHeal = 0;
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        
        //TODO: Wrap this into a proper ticking system.
        if (Health < MaxHealth && ticksSinceLastHeal > healingRate)
        {
            ticksSinceLastHeal = 0;
            Health++;
        }
    }
}