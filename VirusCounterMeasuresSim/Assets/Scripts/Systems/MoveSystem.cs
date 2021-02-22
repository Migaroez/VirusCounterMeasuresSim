using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;

public class MoveSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var deltaTime = Time.DeltaTime;
        return Entities.ForEach((ref Translation translation, ref Movable movable) => {
            if (movable.WaitingForDestination)
            {
                return;
            }
            float3 moveDir = math.normalizesafe(movable.Destination - translation.Value);
            float moveSpeed = 3f;
            translation.Value +=  moveDir * moveSpeed * deltaTime;
            if(math.distance(translation.Value, movable.Destination) < .1f)
            {
                movable.WaitingForDestination = true;
            }
        }).Schedule(inputDeps);
    }

}
