using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldofView : MonoBehaviour
{
    private Mesh mesh;

    // Start is called before the first frame update
    private void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
    }

    private void Update()
    {
        

    Vector3 origin = Vector3.zero;

        float fieldofView = 90f;
        int rayCount = 50;
        float angle = 0f;
        float angleIncrease = fieldofView / rayCount;
        float viewDistance = 50f;

        Vector3[] vertices = new Vector3[rayCount + 1 + 1];
        Vector2[] uv = new Vector2[vertices.Length];
        int[] triangles = new int[rayCount * 3];

        vertices[0]= origin;

        int vertexIndex = 1;
        int triangleIndex = 0;
        for(int i = 0; i <= rayCount; i++)
        {
            Vector3 vertex = origin + LevelManager.GetVectorFromAngle(angle) * viewDistance;
            RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, LevelManager.GetVectorFromAngle(angle), viewDistance);
            if(raycastHit2D.collider == null)
            {
                vertex = origin + LevelManager.GetVectorFromAngle(angle) * viewDistance;
            }
            else
            {
                vertex = raycastHit2D.point;
            }
            vertices[vertexIndex] = vertex;

            if (i > 0)
            {
                triangles[triangleIndex + 0] = 0;
                triangles[triangleIndex + 1] = vertexIndex - 1;
                triangles[triangleIndex + 1] = vertexIndex;

                triangleIndex += 3;
            }

            vertexIndex += 1;

            angle -= angleIncrease;
        }

        vertices[0] = Vector3.zero;
        vertices[1] = new Vector3(50, 0);
        vertices[2] = new Vector3(0, -50);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
    }

    //public void SetOrigin(Vector3 origin)
    //{
        //this.origin = origin;
    //}

    //public void SetAimDirection(Vector3 aimDirection)
    //{

    //}

}
