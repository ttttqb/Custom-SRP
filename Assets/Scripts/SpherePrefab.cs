using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePrefab : MonoBehaviour
{
    public int ShapeID;
    public int MaterialID;
    
    public void SetMaterial (Material material) {
        GetComponent<MeshRenderer>().material = material;
    }
}
