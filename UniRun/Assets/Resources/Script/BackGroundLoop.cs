using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    private float width;

    private void Awake()
    {
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }
    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0f);
        transform.position = (Vector2)transform.position + offset;
       // transform.position = transform.position.AddVector(offset);
    }

    //public Vector2 AddVector(this Vector3 origin, Vector2 addVector)
    //{
    //    Vector2 result = new Vector2(origin.x, origin.y);
    //    result += addVector;
    //    return result;
    //}
}
