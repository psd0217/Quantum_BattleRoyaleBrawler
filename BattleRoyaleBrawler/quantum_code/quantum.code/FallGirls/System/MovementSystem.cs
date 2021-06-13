using System;
using Photon.Deterministic;

namespace Quantum
{
    public unsafe struct FallGirls
    {
        public EntityRef e;
        public Transform3D* t;
        public PhysicsBody3D* b;
        public FallGirl* fg;
    }
    
    public unsafe class MovementSystem : SystemMainThreadFilter<FallGirls>, ISignalOnPlayerDataSet
    {
        public override void Update(Frame f, ref FallGirls filter)
        {
            var input = f.GetPlayerInput(filter.fg->Player);
            var direction = input->Direction.XOY;

            filter.b->AddForce(direction * filter.fg->Acceleration);

            if (input->Jump.WasPressed )
            {
                filter.b->AddLinearImpulse(FPVector3.Up * filter.fg->JumpImpulse);
            }

            var draggedVelocity = filter.b->Velocity.XZ * (FP._1 - filter.fg->Drag * f.DeltaTime);
            filter.b->Velocity.X = draggedVelocity.X;
            filter.b->Velocity.Z = draggedVelocity.Y;

            if(direction != default)
                filter.t->Rotation = FPQuaternion.LookRotation(direction);


            //filter.fg->Grounded = false;
        }

        public void OnPlayerDataSet(Frame f, PlayerRef player)
        {
            var data = f.GetPlayerData(player);
            var prototype = f.FindAsset<EntityPrototype>(data.prefab.Id);
            var e = f.Create(prototype);

            if (f.Unsafe.TryGetPointer<FallGirl>(e, out var fg))
            {
                fg->Player = player;
            }
            if (f.Unsafe.TryGetPointer<Transform3D>(e, out var t))
            {
                t->Position = new FPVector3(player - 4,2,-92);
            }
            //Spawn(f, e, player);
        }

        

        public void OnCollision3D(Frame frame, CollisionInfo3D info)
        {
            if (FPVector3.Angle(info.ContactNormal, FPVector3.Up) < FP._10 * 3)
            {
                if (frame.Unsafe.TryGetPointer<FallGirl>(info.Entity, out var fg))
                {
                    fg->Grounded = true;
                }
            }

           

        }

        
    }
}