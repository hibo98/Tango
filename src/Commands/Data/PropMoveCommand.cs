﻿using ProtoBuf;
using UnityEngine;

namespace CSM.Commands
{
    [ProtoContract]
    public class PropMoveCommand : CommandBase
    {
        [ProtoMember(1)]
        public ushort PropId { get; set; }

        [ProtoMember(2)]
        public Vector3 Position { get; set; }
    }
}
