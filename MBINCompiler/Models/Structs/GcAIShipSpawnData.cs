﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcAIShipSpawnData : NMSTemplate        // size: 0xA8       // in a global?
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Message;

        /* 0x20 */ public TkInputEnum Shortcut;
        /* 0x24 */ public bool WarpIn;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] Padding25;
        /* 0x28 */ public GcAISpaceshipRoles ShipRole;
        /* 0x2C */ public float MinRange;
        /* 0x30 */ public Vector2f Scale;
        [NMS(Size = 0x10)]
        /* 0x38 */ public string Reward;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string RewardMessage;
        /* 0x68 */ public bool AttackFreighter;
        /* 0x6C */ public Vector2f Spread;
        /* 0x74 */ public Vector2f Count;
        /* 0x7C */ public Vector2f StartTime;
        public int SpawnShape;
        /* 0x84 */ public string[] SpawnShapeValues()
        {
            return new[] { "Sphere", "Cone" };
        }

        /* 0x88 */ public GcShipAIPerformanceArray Performances;

        /* 0x98 */ public List<GcAIShipSpawnData> ChildSpawns;
    }
}
