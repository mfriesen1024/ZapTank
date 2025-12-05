using Godot;

namespace ZapTank.Util;

[GlobalClass]
public partial class HealthInfo : Resource
{
    [Export] public int MaxHealth = 100;

    /// <summary>
    /// The number of ticks before 1 HP is recovered.
    /// </summary>
    [Export] public int HealingRate = 10;
}