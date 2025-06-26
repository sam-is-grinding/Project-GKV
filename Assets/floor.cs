using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [SerializeField] private GameObject floorPlane;
    private MeshRenderer rend;
    
    void Start()
    {
        rend = floorPlane.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        rend.material.mainTextureOffset = new Vector2(0f, -Time.time * 3f);
    }
}
