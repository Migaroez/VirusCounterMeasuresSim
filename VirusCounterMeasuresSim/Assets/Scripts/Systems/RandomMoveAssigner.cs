using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;

public class RandomMoveAssigner : JobComponentSystem
{
    private Unity.Mathematics.Random random;

    protected override void OnCreate()
    {
        random = new Unity.Mathematics.Random(56);
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        Unity.Mathematics.Random random = new Unity.Mathematics.Random(this.random.NextUInt(1, 10000));
        return Entities.ForEach((ref RandomMoveAssignable randomMoveAssignable, ref Movable movable) =>
        {
            if (movable.WaitingForDestination == false)
            {
                return;
            }
            movable.Destination = randomMoveAssignable.HomeLocation + new float3(random.NextInt(-10, 10), 0, random.NextInt(-10, 10));
            movable.WaitingForDestination = false;
        }).Schedule(inputDeps);
    }

}
