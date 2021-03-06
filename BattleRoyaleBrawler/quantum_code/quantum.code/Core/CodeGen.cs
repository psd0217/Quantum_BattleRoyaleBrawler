/**
  * This code was auto-generated by a tool, every time
  * the tool executes this code will be reset.
  *
  * If you need to extend the classes generated to add
  * fields or methods to them, please create partial
  * declarations in another file.
  **/
#pragma warning disable 0649
#pragma warning disable 1522
#pragma warning disable 0414
#pragma warning disable 0219
#pragma warning disable 0109


namespace Quantum {
  using System;
  using System.Collections.Generic;
  using System.Runtime.InteropServices;
  using Photon.Deterministic;
  using Quantum.Core;
  using Quantum.Collections;
  using Quantum.Inspector;
  using Optional = Quantum.Inspector.OptionalAttribute;
  
  [System.FlagsAttribute()]
  public enum InputButtons : int {
    Jump = 1 << 0,
  }
  public static unsafe partial class InputButtons_ext {
    public static Boolean HasFlag(this InputButtons self, InputButtons flag) {
      return (self & flag) == flag;
    }
    public static InputButtons SetFlag(this InputButtons self, InputButtons flag) {
      return self | flag;
    }
    public static InputButtons ClearFlag(this InputButtons self, InputButtons flag) {
      return self & ~flag;
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet1024 {
    public const Int32 SIZE = 128;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[16];
    public const Int32 BitsSize = 1024;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet1024*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 1024, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet1024* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet1024* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet1024* set) {
      Native.Utils.Clear(&set->bits[0], 128);
    }
    public static Boolean IsSet(BitSet1024* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet1024 FromArray(UInt64[] values) {
      Assert.Always(16 == values.Length);
      BitSet1024 result = default;
      for (int i = 0; i < 16; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 37;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 16; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet1024*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 16);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet128 {
    public const Int32 SIZE = 16;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[2];
    public const Int32 BitsSize = 128;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet128*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 128, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet128* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet128* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet128* set) {
      Native.Utils.Clear(&set->bits[0], 16);
    }
    public static Boolean IsSet(BitSet128* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet128 FromArray(UInt64[] values) {
      Assert.Always(2 == values.Length);
      BitSet128 result = default;
      for (int i = 0; i < 2; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 41;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 2; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet128*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 2);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet2048 {
    public const Int32 SIZE = 256;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[32];
    public const Int32 BitsSize = 2048;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet2048*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 2048, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet2048* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet2048* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet2048* set) {
      Native.Utils.Clear(&set->bits[0], 256);
    }
    public static Boolean IsSet(BitSet2048* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet2048 FromArray(UInt64[] values) {
      Assert.Always(32 == values.Length);
      BitSet2048 result = default;
      for (int i = 0; i < 32; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 43;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 32; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet2048*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 32);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet256 {
    public const Int32 SIZE = 32;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[4];
    public const Int32 BitsSize = 256;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet256*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 256, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet256* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet256* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet256* set) {
      Native.Utils.Clear(&set->bits[0], 32);
    }
    public static Boolean IsSet(BitSet256* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet256 FromArray(UInt64[] values) {
      Assert.Always(4 == values.Length);
      BitSet256 result = default;
      for (int i = 0; i < 4; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 47;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 4; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet256*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 4);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet4096 {
    public const Int32 SIZE = 512;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[64];
    public const Int32 BitsSize = 4096;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet4096*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 4096, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet4096* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet4096* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet4096* set) {
      Native.Utils.Clear(&set->bits[0], 512);
    }
    public static Boolean IsSet(BitSet4096* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet4096 FromArray(UInt64[] values) {
      Assert.Always(64 == values.Length);
      BitSet4096 result = default;
      for (int i = 0; i < 64; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 53;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 64; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet4096*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 64);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct BitSet512 {
    public const Int32 SIZE = 64;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    private fixed UInt64 bits[8];
    public const Int32 BitsSize = 512;
    public static void Print(void* ptr, FramePrinter printer) {
      var p = (BitSet512*)ptr;
      printer.ScopeBegin();
      UnmanagedUtils.PrintBytesBits((byte*)&p->bits, 512, 64, printer);
      printer.ScopeEnd();
    }
    public static void Set(BitSet512* set, Int32 bit) {
      set->bits[bit/64] |= (1UL<<(bit%64));
    }
    public static void Clear(BitSet512* set, Int32 bit) {
      set->bits[bit/64] &= ~(1UL<<(bit%64));
    }
    public static void ClearAll(BitSet512* set) {
      Native.Utils.Clear(&set->bits[0], 64);
    }
    public static Boolean IsSet(BitSet512* set, Int32 bit) {
      return (set->bits[bit/64]&(1UL<<(bit%64))) != 0UL;
    }
    public static BitSet512 FromArray(UInt64[] values) {
      Assert.Always(8 == values.Length);
      BitSet512 result = default;
      for (int i = 0; i < 8; ++i) {
        result.bits[i] = values[i];
      }
      return result;
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 59;
        fixed (UInt64* p = bits) {
          for (var i = 0; i < 8; ++i) {
            hash = hash * 31 + p[i].GetHashCode();
          }
        }
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (BitSet512*)ptr;
        serializer.Stream.SerializeBuffer(&p->bits[0], 8);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Input {
    public const Int32 SIZE = 16;
    public const Int32 ALIGNMENT = 4;
    [FieldOffset(0)]
    public Byte EncodedDirection;
    [FieldOffset(4)]
    public Button Jump;
    public const int MAX_COUNT = 6;
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 61;
        hash = hash * 31 + EncodedDirection.GetHashCode();
        hash = hash * 31 + Jump.GetHashCode();
        return hash;
      }
    }
    public static Input Read(FrameSerializer serializer) {
      Input i = new Input();
      Serialize(&i, serializer);
      return i;
    }
    public static void Write(FrameSerializer serializer, Input i) {
      Serialize(&i, serializer);
    }
    public Boolean IsDown(InputButtons button) {
      switch (button) {
        case InputButtons.Jump: return Jump.IsDown;
      }
      return false;
    }
    public Boolean WasPressed(InputButtons button) {
      switch (button) {
        case InputButtons.Jump: return Jump.WasPressed;
      }
      return false;
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (Input*)ptr;
        serializer.Stream.Serialize(&p->EncodedDirection);
        Button.Serialize(&p->Jump, serializer);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct _globals_ {
    public const Int32 SIZE = 432;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(16)]
    public FP DeltaTime;
    [FieldOffset(144)]
    public FrameMetaData FrameMetaData;
    [FieldOffset(8)]
    public AssetRefMap Map;
    [FieldOffset(24)]
    public NavMeshRegionMask NavMeshRegions;
    [FieldOffset(200)]
    public PhysicsSceneSettings PhysicsSettings;
    [FieldOffset(128)]
    public RNGSession RngSession;
    [FieldOffset(168)]
    public BitSet256 Systems;
    [FieldOffset(0)]
    [FramePrinter.PtrQListAttribute(typeof(PlayerRef))]
    private Ptr WinnersPtr;
    [FieldOffset(32)]
    [FramePrinter.FixedArrayAttribute(typeof(Input), 6)]
    private fixed Byte _input_[96];
    public QListPtr<PlayerRef> Winners {
      get {
        return new QListPtr<PlayerRef>(WinnersPtr);
      }
      set {
        WinnersPtr = value.Ptr;
      }
    }
    public FixedArray<Input> input {
      get {
        fixed (byte* p = _input_) { return new FixedArray<Input>(p, 16, 6); }
      }
    }
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 67;
        hash = hash * 31 + DeltaTime.GetHashCode();
        hash = hash * 31 + FrameMetaData.GetHashCode();
        hash = hash * 31 + Map.GetHashCode();
        hash = hash * 31 + NavMeshRegions.GetHashCode();
        hash = hash * 31 + PhysicsSettings.GetHashCode();
        hash = hash * 31 + RngSession.GetHashCode();
        hash = hash * 31 + Systems.GetHashCode();
        hash = hash * 31 + WinnersPtr.GetHashCode();
        hash = hash * 31 + input.GetHashCode();
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (_globals_*)ptr;
        QList<PlayerRef>.Serialize(&p->WinnersPtr, serializer, PlayerRef.Serialize);
        AssetRefMap.Serialize(&p->Map, serializer);
        FP.Serialize(&p->DeltaTime, serializer);
        NavMeshRegionMask.Serialize(&p->NavMeshRegions, serializer);
        FixedArray<Input>.Serialize(p->input, serializer, Quantum.Input.Serialize);
        RNGSession.Serialize(&p->RngSession, serializer);
        FrameMetaData.Serialize(&p->FrameMetaData, serializer);
        Quantum.BitSet256.Serialize(&p->Systems, serializer);
        PhysicsSceneSettings.Serialize(&p->PhysicsSettings, serializer);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct FallGirl : Quantum.IComponent {
    public const Int32 SIZE = 32;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(8)]
    public FP Acceleration;
    [FieldOffset(16)]
    public FP Drag;
    [FieldOffset(4)]
    public QBoolean Grounded;
    [FieldOffset(24)]
    public FP JumpImpulse;
    [FieldOffset(0)]
    public PlayerRef Player;
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 71;
        hash = hash * 31 + Acceleration.GetHashCode();
        hash = hash * 31 + Drag.GetHashCode();
        hash = hash * 31 + Grounded.GetHashCode();
        hash = hash * 31 + JumpImpulse.GetHashCode();
        hash = hash * 31 + Player.GetHashCode();
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (FallGirl*)ptr;
        PlayerRef.Serialize(&p->Player, serializer);
        QBoolean.Serialize(&p->Grounded, serializer);
        FP.Serialize(&p->Acceleration, serializer);
        FP.Serialize(&p->Drag, serializer);
        FP.Serialize(&p->JumpImpulse, serializer);
    }
  }
  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct RotatingObstacle : Quantum.IComponent {
    public const Int32 SIZE = 24;
    public const Int32 ALIGNMENT = 8;
    [FieldOffset(0)]
    public FPVector3 AxisSpeed;
    public override Int32 GetHashCode() {
      unchecked { 
        var hash = 73;
        hash = hash * 31 + AxisSpeed.GetHashCode();
        return hash;
      }
    }
    public static void Serialize(void* ptr, FrameSerializer serializer) {
        var p = (RotatingObstacle*)ptr;
        FPVector3.Serialize(&p->AxisSpeed, serializer);
    }
  }
  public unsafe partial class Frame {
    partial void AllocGen() {
      _globals = (_globals_*)Context.Allocator.AllocAndClear(sizeof(_globals_));
    }
    partial void FreeGen() {
      Context.Allocator.Free(_globals);
    }
    partial void CopyFromGen(Frame frame) {
      Native.Utils.Copy(_globals, frame._globals, sizeof(_globals_));
    }
    partial void InitGen() {
      ComponentTypeId.Setup(() => {
        ComponentTypeId.Add<Quantum.FallGirl>(new ComponentCallbacks(Quantum.FallGirl.Serialize));
        ComponentTypeId.Add<Quantum.RotatingObstacle>(new ComponentCallbacks(Quantum.RotatingObstacle.Serialize));
      });
      Initialize(this, this.SimulationConfig.Entities);
      _ComponentSignalsOnAdded = new ComponentReactiveCallbackInvoker[ComponentTypeId.Type.Length];
      _ComponentSignalsOnRemoved = new ComponentReactiveCallbackInvoker[ComponentTypeId.Type.Length];
      BuildSignalsArrayOnComponentAdded<CharacterController2D>();
      BuildSignalsArrayOnComponentRemoved<CharacterController2D>();
      BuildSignalsArrayOnComponentAdded<CharacterController3D>();
      BuildSignalsArrayOnComponentRemoved<CharacterController3D>();
      BuildSignalsArrayOnComponentAdded<Quantum.FallGirl>();
      BuildSignalsArrayOnComponentRemoved<Quantum.FallGirl>();
      BuildSignalsArrayOnComponentAdded<MapEntityLink>();
      BuildSignalsArrayOnComponentRemoved<MapEntityLink>();
      BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceAgent>();
      BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceAgent>();
      BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceObstacle>();
      BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceObstacle>();
      BuildSignalsArrayOnComponentAdded<NavMeshPathfinder>();
      BuildSignalsArrayOnComponentRemoved<NavMeshPathfinder>();
      BuildSignalsArrayOnComponentAdded<NavMeshSteeringAgent>();
      BuildSignalsArrayOnComponentRemoved<NavMeshSteeringAgent>();
      BuildSignalsArrayOnComponentAdded<PhysicsBody2D>();
      BuildSignalsArrayOnComponentRemoved<PhysicsBody2D>();
      BuildSignalsArrayOnComponentAdded<PhysicsBody3D>();
      BuildSignalsArrayOnComponentRemoved<PhysicsBody3D>();
      BuildSignalsArrayOnComponentAdded<PhysicsCollider2D>();
      BuildSignalsArrayOnComponentRemoved<PhysicsCollider2D>();
      BuildSignalsArrayOnComponentAdded<PhysicsCollider3D>();
      BuildSignalsArrayOnComponentRemoved<PhysicsCollider3D>();
      BuildSignalsArrayOnComponentAdded<Quantum.RotatingObstacle>();
      BuildSignalsArrayOnComponentRemoved<Quantum.RotatingObstacle>();
      BuildSignalsArrayOnComponentAdded<Transform2D>();
      BuildSignalsArrayOnComponentRemoved<Transform2D>();
      BuildSignalsArrayOnComponentAdded<Transform2DVertical>();
      BuildSignalsArrayOnComponentRemoved<Transform2DVertical>();
      BuildSignalsArrayOnComponentAdded<Transform3D>();
      BuildSignalsArrayOnComponentRemoved<Transform3D>();
      BuildSignalsArrayOnComponentAdded<View>();
      BuildSignalsArrayOnComponentRemoved<View>();
    }
    public void SetPlayerInput(Int32 player, Input input) {
      if ((uint)player >= (uint)_globals->input.Length) { throw new System.ArgumentOutOfRangeException("player"); }
      var i = _globals->input.GetPointer(player);
      i->Jump = i->Jump.Update(this.Number, input.Jump);
      i->EncodedDirection = input.EncodedDirection;
    }
    public Input* GetPlayerInput(Int32 player) {
      if ((uint)player >= (uint)_globals->input.Length) { throw new System.ArgumentOutOfRangeException("player"); }
      return _globals->input.GetPointer(player);
    }
    public unsafe partial struct FrameSignals {
    }
    public unsafe partial struct FrameEvents {
      public const Int32 EVENT_TYPE_COUNT = 0;
      public static Int32 GetParentEventID(Int32 eventID) {
        switch (eventID) {
          default: return -1;
        }
      }
      public static System.Type GetEventType(Int32 eventID) {
        switch (eventID) {
          default: throw new System.ArgumentOutOfRangeException("eventID");
        }
      }
    }
    public unsafe partial struct FrameAssets {
    }
  }
  #region BitStreamExtensions
  static
  public unsafe partial class BitStreamExtensions {
  }
  #endregion
  public unsafe partial class ComponentPrototypeVisitor : Prototypes.ComponentPrototypeVisitorBase {
    public virtual void Visit(Prototypes.FallGirl_Prototype prototype) {
      VisitFallback(prototype);
    }
    public virtual void Visit(Prototypes.RotatingObstacle_Prototype prototype) {
      VisitFallback(prototype);
    }
  }
  public static unsafe partial class Constants {
  }
  public unsafe partial class TypeRegistry {
    partial void AddGenerated() {
      Register(typeof(AssetGuid), AssetGuid.SIZE);
      Register(typeof(AssetRefCharacterController2DConfig), AssetRefCharacterController2DConfig.SIZE);
      Register(typeof(AssetRefCharacterController3DConfig), AssetRefCharacterController3DConfig.SIZE);
      Register(typeof(AssetRefEntityPrototype), AssetRefEntityPrototype.SIZE);
      Register(typeof(AssetRefEntityView), AssetRefEntityView.SIZE);
      Register(typeof(AssetRefMap), AssetRefMap.SIZE);
      Register(typeof(AssetRefNavMesh), AssetRefNavMesh.SIZE);
      Register(typeof(AssetRefNavMeshAgentConfig), AssetRefNavMeshAgentConfig.SIZE);
      Register(typeof(AssetRefPhysicsMaterial), AssetRefPhysicsMaterial.SIZE);
      Register(typeof(AssetRefPolygonCollider), AssetRefPolygonCollider.SIZE);
      Register(typeof(AssetRefTerrainCollider), AssetRefTerrainCollider.SIZE);
      Register(typeof(Quantum.BitSet1024), Quantum.BitSet1024.SIZE);
      Register(typeof(Quantum.BitSet128), Quantum.BitSet128.SIZE);
      Register(typeof(Quantum.BitSet2048), Quantum.BitSet2048.SIZE);
      Register(typeof(Quantum.BitSet256), Quantum.BitSet256.SIZE);
      Register(typeof(Quantum.BitSet4096), Quantum.BitSet4096.SIZE);
      Register(typeof(Quantum.BitSet512), Quantum.BitSet512.SIZE);
      Register(typeof(Button), Button.SIZE);
      Register(typeof(CharacterController2D), CharacterController2D.SIZE);
      Register(typeof(CharacterController3D), CharacterController3D.SIZE);
      Register(typeof(ColorRGBA), ColorRGBA.SIZE);
      Register(typeof(ComponentPrototypeRef), ComponentPrototypeRef.SIZE);
      Register(typeof(EntityPrototypeRef), EntityPrototypeRef.SIZE);
      Register(typeof(EntityRef), EntityRef.SIZE);
      Register(typeof(FP), FP.SIZE);
      Register(typeof(FPBounds2), FPBounds2.SIZE);
      Register(typeof(FPBounds3), FPBounds3.SIZE);
      Register(typeof(FPMatrix2x2), FPMatrix2x2.SIZE);
      Register(typeof(FPMatrix4x4), FPMatrix4x4.SIZE);
      Register(typeof(FPQuaternion), FPQuaternion.SIZE);
      Register(typeof(FPVector2), FPVector2.SIZE);
      Register(typeof(FPVector3), FPVector3.SIZE);
      Register(typeof(Quantum.FallGirl), Quantum.FallGirl.SIZE);
      Register(typeof(FrameMetaData), FrameMetaData.SIZE);
      Register(typeof(Quantum.Input), Quantum.Input.SIZE);
      Register(typeof(Quantum.InputButtons), 4);
      Register(typeof(LayerMask), LayerMask.SIZE);
      Register(typeof(MapEntityId), MapEntityId.SIZE);
      Register(typeof(MapEntityLink), MapEntityLink.SIZE);
      Register(typeof(NavMeshAvoidanceAgent), NavMeshAvoidanceAgent.SIZE);
      Register(typeof(NavMeshAvoidanceObstacle), NavMeshAvoidanceObstacle.SIZE);
      Register(typeof(NavMeshPathfinder), NavMeshPathfinder.SIZE);
      Register(typeof(NavMeshRegionMask), NavMeshRegionMask.SIZE);
      Register(typeof(NavMeshSteeringAgent), NavMeshSteeringAgent.SIZE);
      Register(typeof(NullableFP), NullableFP.SIZE);
      Register(typeof(NullableFPVector2), NullableFPVector2.SIZE);
      Register(typeof(NullableFPVector3), NullableFPVector3.SIZE);
      Register(typeof(PhysicsBody2D), PhysicsBody2D.SIZE);
      Register(typeof(PhysicsBody3D), PhysicsBody3D.SIZE);
      Register(typeof(PhysicsCollider2D), PhysicsCollider2D.SIZE);
      Register(typeof(PhysicsCollider3D), PhysicsCollider3D.SIZE);
      Register(typeof(PhysicsSceneSettings), PhysicsSceneSettings.SIZE);
      Register(typeof(PlayerRef), PlayerRef.SIZE);
      Register(typeof(Ptr), Ptr.SIZE);
      Register(typeof(QBoolean), QBoolean.SIZE);
      Register(typeof(RNGSession), RNGSession.SIZE);
      Register(typeof(Quantum.RotatingObstacle), Quantum.RotatingObstacle.SIZE);
      Register(typeof(Transform2D), Transform2D.SIZE);
      Register(typeof(Transform2DVertical), Transform2DVertical.SIZE);
      Register(typeof(Transform3D), Transform3D.SIZE);
      Register(typeof(View), View.SIZE);
      Register(typeof(Quantum._globals_), Quantum._globals_.SIZE);
    }
  }
  public unsafe partial class FramePrinterGen {
    public static void EnsureNotStripped() {
      FramePrinter.EnsurePrimitiveNotStripped<Quantum.InputButtons>();
    }
  }
}
namespace Quantum.Prototypes {
  using System;
  using System.Collections.Generic;
  using System.Runtime.InteropServices;
  using Photon.Deterministic;
  using Quantum.Core;
  using Quantum.Collections;
  using Quantum.Inspector;
  using Optional = Quantum.Inspector.OptionalAttribute;
  
  [System.SerializableAttribute()]
  [EnumWrapper(typeof(InputButtons))]
  public unsafe partial struct InputButtons_Prototype {
    public Int32 Value;
    public static implicit operator InputButtons(InputButtons_Prototype value) {
        return (InputButtons)value.Value;
    }
    public static implicit operator InputButtons_Prototype(InputButtons value) {
        return new InputButtons_Prototype() { Value = (Int32)value };
    }
  }
  [System.SerializableAttribute()]
  [ComponentPrototypeAttribute(typeof(FallGirl))]
  public unsafe sealed partial class FallGirl_Prototype : ComponentPrototype<FallGirl> {
    public PlayerRef Player;
    public FP Acceleration;
    public FP JumpImpulse;
    public FP Drag;
    public QBoolean Grounded;
    partial void MaterializeUser(Frame frame, ref FallGirl result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
      FallGirl component = default;
      Materialize((Frame)f, ref component, in context);
      return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public override Boolean SetEntityRefs(FrameBase f, EntityRef entity, MapEntityLookup mapEntities) {
      FallGirl component = f.Get<FallGirl>(entity);
      SetEntityRefs((Frame)f, ref component, mapEntities);
      return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref FallGirl result, in PrototypeMaterializationContext context) {
      result.Acceleration = this.Acceleration;
      result.Drag = this.Drag;
      result.Grounded = this.Grounded;
      result.JumpImpulse = this.JumpImpulse;
      result.Player = this.Player;
      MaterializeUser(frame, ref result, in context);
    }
    public void SetEntityRefs(Frame frame, ref FallGirl result, MapEntityLookup mapEntities) {
    }
    public override void Dispatch(ComponentPrototypeVisitorBase visitor) {
      ((ComponentPrototypeVisitor)visitor).Visit(this);
    }
  }
  [System.SerializableAttribute()]
  public unsafe sealed partial class Input_Prototype : IPrototype {
    public Button Jump;
    public Byte EncodedDirection;
    partial void MaterializeUser(Frame frame, ref Input result, in PrototypeMaterializationContext context);
    public void Materialize(Frame frame, ref Input result, in PrototypeMaterializationContext context) {
      result.EncodedDirection = this.EncodedDirection;
      result.Jump = this.Jump;
      MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [ComponentPrototypeAttribute(typeof(RotatingObstacle))]
  public unsafe sealed partial class RotatingObstacle_Prototype : ComponentPrototype<RotatingObstacle> {
    public FPVector3 AxisSpeed;
    partial void MaterializeUser(Frame frame, ref RotatingObstacle result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
      RotatingObstacle component = default;
      Materialize((Frame)f, ref component, in context);
      return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public override Boolean SetEntityRefs(FrameBase f, EntityRef entity, MapEntityLookup mapEntities) {
      RotatingObstacle component = f.Get<RotatingObstacle>(entity);
      SetEntityRefs((Frame)f, ref component, mapEntities);
      return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref RotatingObstacle result, in PrototypeMaterializationContext context) {
      result.AxisSpeed = this.AxisSpeed;
      MaterializeUser(frame, ref result, in context);
    }
    public void SetEntityRefs(Frame frame, ref RotatingObstacle result, MapEntityLookup mapEntities) {
    }
    public override void Dispatch(ComponentPrototypeVisitorBase visitor) {
      ((ComponentPrototypeVisitor)visitor).Visit(this);
    }
  }
  public unsafe partial class FlatEntityPrototypeContainer {
    [FixedArray(0, 1)]
    public List<Prototypes.FallGirl_Prototype> FallGirl;
    [FixedArray(0, 1)]
    public List<Prototypes.RotatingObstacle_Prototype> RotatingObstacle;
    partial void CollectGen(List<ComponentPrototype> target) {
      Collect(FallGirl, target);
      Collect(RotatingObstacle, target);
    }
    public unsafe partial class StoreVisitor {
      public override void Visit(Prototypes.FallGirl_Prototype prototype) {
        Storage.Store(prototype, ref Storage.FallGirl);
      }
      public override void Visit(Prototypes.RotatingObstacle_Prototype prototype) {
        Storage.Store(prototype, ref Storage.RotatingObstacle);
      }
    }
  }
}
#pragma warning restore 0649
#pragma warning restore 1522
#pragma warning restore 0414
#pragma warning restore 0219
#pragma warning restore 0109
