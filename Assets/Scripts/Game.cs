using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    [SerializeField] SpherePrefab spherePrefab = default;

    [SerializeField] Material[] materials = default;

    //private SpherePrefab[] spheres;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        Vector2 offset = new Vector2(2, 2);
        for (int i = 0, t = 0; i < 9; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 8; j++, t++)
                {
                    SpherePrefab instance = Instantiate(spherePrefab);
                    instance.SetMaterial(materials[Random.Range(0, materials.Length)]);
                    instance.transform.localPosition = new Vector3(j-offset.x, 0, i-offset.y);
                }
            }
            else
            {
                for (int j = 0; j < 9; j++, t++)
                {
                    SpherePrefab instance = Instantiate(spherePrefab);
                    instance.SetMaterial(materials[Random.Range(0, materials.Length)]);
                    instance.transform.localPosition = new Vector3(j-offset.x*9/8, 0, i-offset.y);
                }
            }
        }
    }
    
}
