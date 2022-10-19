using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateWorldSpaceMaterial : MonoBehaviour
{
    public Material material;

    void Update()
    {
        material.SetVector("_Center", transform.position);
    }
}
