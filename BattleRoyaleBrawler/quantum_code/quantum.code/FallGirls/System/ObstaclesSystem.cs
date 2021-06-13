using Photon.Deterministic;

namespace Quantum
{
    public unsafe struct Obstacles
    {
        public EntityRef e;
        public Transform3D* t;
        public PhysicsBody3D* b;
        public RotatingObstacle* ro;
    }
    public unsafe class ObstaclesSystem : SystemMainThreadFilter<Obstacles>
    {
        public override void Update(Frame f, ref Obstacles filter)
        {
            filter.b->AngularVelocity = filter.ro->AxisSpeed * FP.Deg2Rad;
            filter.t->Rotate(filter.ro->AxisSpeed * f.DeltaTime);
            filter.t->Rotation = filter.t->Rotation.Normalized;
        }
    }
}