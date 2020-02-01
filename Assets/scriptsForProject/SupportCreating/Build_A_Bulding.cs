using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Bulding : MonoBehaviour
{

    float Height;

    float Width;

    float Depth;

    Terrain terrain;

    public GameObject Plane;
    Vector3[] cursor_vertices;

    RaycastHit hit;

    int Builing_Num;
    // Start is called before the first frame update
    void Start()
    {
        Builing_Num = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        float offset = 0.2f;
        float y = offset + terrain.gameObject.GetComponent<MeshFilter>().mesh.vertices[0].y;

        if (Physics.BoxCast(Input.mousePosition, new Vector3(10f, 0f, 10f), Vector3.down * 2f, Quaternion.identity))
        {
            for(int i=0;i<hit.collider.gameObject.GetComponent<MeshFilter>().mesh.vertices.Length;i++)
            {


            }
        }
       
        
    }

    void Create_Building(Vector3 in_Pos)
    {
        GameObject building = GameObject.CreatePrimitive(PrimitiveType.Cube);
        building.transform.position = in_Pos;
        building.transform.localScale = Vector3.one;
        building.transform.rotation = Quaternion.identity;
    }
}
