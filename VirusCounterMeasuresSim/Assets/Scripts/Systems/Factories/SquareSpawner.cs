using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class RectangleSpawner : ComponentSystem
{
    protected override void OnStartRunning()
    {
        var startTime = UnityEngine.Time.realtimeSinceStartup;

        Entities.ForEach((ref RectangleSpawn settings) =>
        {
            for (int i = 0; i < settings.TotalAmount; i++)
            {
                var entity = EntityManager.Instantiate(settings.Prefab);
                var spawnPosition = new float3(
                    (i / settings.AmountPerRow - (settings.Center ? settings.AmountPerRow / 2 : 0)) * settings.DistanceRow,
                    0,
                    (i % settings.AmountPerRow - (settings.Center ? settings.TotalAmount / settings.AmountPerRow / 2 : 0)) * settings.DistanceColumn);
                //todo: check if we just cant set the data instead of creating a new struct?
                EntityManager.SetComponentData<Translation>(entity, new Translation
                {
                    Value = spawnPosition
                });
                EntityManager.SetComponentData<RandomMoveAssignable>(entity, new RandomMoveAssignable
                {
                    HomeLocation = spawnPosition
                });
            }
        });

        UnityEngine.Debug.Log("Spawned everything in " + ((UnityEngine.Time.realtimeSinceStartup - startTime) * 1000f) + " ms");
    }

    protected override void OnUpdate()
    {

    }
}
