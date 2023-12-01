using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHp = 5;
    [SerializeField] int currentHp = 0;

    void Start()
    {
        currentHp = maxHp;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHp--;

        if (currentHp < 1)
        {
            Destroy(gameObject);
        }
    }
}
