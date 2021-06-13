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

            if (input->Jump.WasPressed)
            {
                filter.b->AddLinearImpulse(FPVector3.Up * filter.fg->JumpImpulse);
            }
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
        }
    }
}