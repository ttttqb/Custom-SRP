using System;
using UnityEngine;

[DisallowMultipleComponent]
public class PerObjectMaterialProperties : MonoBehaviour {
	
	// ReSharper disable once InconsistentNaming
	static int baseColorId = Shader.PropertyToID("_BaseColor");
	private static MaterialPropertyBlock block;
	static int cutoffId = Shader.PropertyToID("_Cutoff");
	
	[SerializeField, Range(0f, 1f)]
	float cutoff = 0.5f;
	
    [SerializeField] private Color baseColor = Color.white;

    private void OnValidate()
    {
	    if (block == null)
	    {
		    block = new MaterialPropertyBlock();
	    }
	    block.SetColor(baseColorId, baseColor);
	    block.SetFloat(cutoffId, cutoff);
	    GetComponent<Renderer>().SetPropertyBlock(block);
    }

    private void Awake()
    {
	    OnValidate();
    }
}