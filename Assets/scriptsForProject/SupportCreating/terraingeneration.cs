using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class terraingeneration : MonoBehaviour
{
    int width = 10;
    int depth = 10;
    Vector3[] vertices;
    // Start is called before the first frame update
    void Start()
    {

        //Create Meshes
        var mesh = new Mesh();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                mesh.vertices[i].x = i;
                mesh.vertices[i].y = 0;
                mesh.vertices[i].z = j;
               
            }
        }

        
        mesh.RecalculateNormals();
        
        var filter = GetComponent<MeshFilter>();

        filter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
