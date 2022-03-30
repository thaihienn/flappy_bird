using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatObject : MonoBehaviour
{
   private BoxCollider2D bc2d;
    private float width;

    // Start is called before the first frame update
    void Start()
    {
       bc2d = GetComponent<BoxCollider2D>();
       width = bc2d.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -width)
          RepeatGround();
    }
    void RepeatGround()
    {
       Vector2 offset = new Vector2(width * 2f, 0);
       transform.position = (Vector2)transform.position + offset;
    }
}
