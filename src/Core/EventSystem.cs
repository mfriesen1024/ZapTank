using System;
using ZapTank.Controllers;

namespace ZapTank.Core;

public static class EventSystem
{
    public static Action<TankController> InputUpdatePush;
}