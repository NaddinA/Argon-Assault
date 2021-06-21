using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAdder : MonoBehaviour
{
    void start() {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
