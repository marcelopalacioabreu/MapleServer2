﻿using MaplePacketLib2.Tools;
using MapleServer2.Constants;
using MapleServer2.Packets;
using MapleServer2.Servers.Game;
using Microsoft.Extensions.Logging;

namespace MapleServer2.PacketHandlers.Game {
    public class InsigniaHandler : GamePacketHandler {
        public override ushort OpCode => RecvOp.NAMETAG_SYMBOL;

        public InsigniaHandler(ILogger<InsigniaHandler> logger) : base(logger) { }

        public override void Handle(GameSession session, PacketReader packet) {
            short insigniaID = packet.ReadShort();
            System.Console.WriteLine("insigniaID: " + insigniaID);
            session.FieldManager.BroadcastPacket(InsigniaPacket.UpdateInsignia(session, insigniaID));
        }
    }
}