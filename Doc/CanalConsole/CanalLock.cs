using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanalConsole
{
    public enum WaterLevel
    {
        Low,
        High
    }
    public class CanalLock
    {
        public WaterLevel CanalLockWaterLevel { get; private set; } = WaterLevel.Low;
        public bool HighWaterGateOpen { get; private set; } = false;
        public bool LowWaterGateOpen { get; private set; } = false;

        public void SetHighGate(bool open)
        {
            //if (open && (CanalLockWaterLevel == WaterLevel.High))
            //    HighWaterGateOpen = open;
            //else if (open && (CanalLockWaterLevel == WaterLevel.Low))
            //    throw new InvalidOperationException("Cannot open high gate when the water is low");

            HighWaterGateOpen = (open, HighWaterGateOpen, CanalLockWaterLevel) switch
            {
                (false, _, _) => false,
                (true, _, WaterLevel.High) => true,
                (true, false, WaterLevel.Low) => throw new InvalidOperationException("Cannot open high gate when the water is low"),
                _ => throw new InvalidOperationException("Invalid internal state"),
            };
        }
        public void SetLowGate(bool open)
        {
            LowWaterGateOpen = open;
        }
        public void SetWaterLevel(WaterLevel newLevel)
        {
            CanalLockWaterLevel = newLevel;
        }

        public override string ToString() =>
            $"The lower gate is {(LowWaterGateOpen ? "Open" : "Closed")}. " +
            $"The upper gate is {(HighWaterGateOpen ? "Open" : "Closed")}. " +
            $"The water level is {CanalLockWaterLevel}";
    }
}
