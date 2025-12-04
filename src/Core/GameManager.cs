using System;
using Godot;
using SFIUtils.Logging;
using Logger = SFIUtils.Logging.Logger;

namespace ZapTank.Core;

public partial class GameManager:Node
{
    /// <summary>
    /// Singleton instance of GM.
    /// </summary>
    public static GameManager Instance { get; protected set; }
    
    public static Logger PlayerLog => Instance.logger;
    
    Logger logger;

    public override void _Ready()
    {
        // Singleton set.
        if (Instance == null)
        {
            Instance = this;
        }
        else{
            QueueFree();
            return;
        }

        logger = new Logger("./logs", "Player");

#if DEBUG
        logger.MinimumFileLogLevel = LogLevel.Debug;
        logger.Log("Debug active.");
#endif
        logger.Log("GM Initialized, proceed to Ready.");
    }
}