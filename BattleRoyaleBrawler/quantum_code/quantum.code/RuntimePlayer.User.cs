using Photon.Deterministic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quantum {
  partial class RuntimePlayer
  {

    public AssetRefEntityPrototype prefab;
    public string Nickname;
    partial void SerializeUserData(BitStream stream)
    {
      // implementation
      stream.Serialize(ref prefab);
      stream.Serialize(ref Nickname);
    }
  }
}
