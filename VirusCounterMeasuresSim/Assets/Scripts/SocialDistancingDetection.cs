using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancingDetection : MonoBehaviour
{
    private const float contactDistance = 1.0f;
    private const float shortDistance = 1.5f;
    private const float mediumDistance = 3.5f;
    private const float longDistance = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // todo: check performance difference between standard distance and using custom math that avoids roots
    void OnTriggerEnter(Collider other)
    {
        var distance = Vector3.Distance(other.transform.position, transform.position);
        if (distance <= contactDistance)
        {
            Debug.Log($"SocialDistancingDetection : {transform.name} - {other.transform.name} [contact])");
            return;
        }
        if (distance <= shortDistance)
        {
            Debug.Log($"SocialDistancingDetection : {transform.name} - {other.transform.name} [short])");
            return;
        }
        if (distance <= mediumDistance)
        {
            Debug.Log($"SocialDistancingDetection : {transform.name} - {other.transform.name} [medium])");
            return;
        }
        if (distance <= longDistance)
        {
            Debug.Log($"SocialDistancingDetection : {transform.name} - {other.transform.name} [long])");
            return;
        }
    }
}
