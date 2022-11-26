using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    private float velocity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = - Input.GetAxis( "Horizontal" );
        var y = - Input.GetAxis( "Vertical" );

        x *= Time.deltaTime * velocity;
        y *= Time.deltaTime * velocity;

        transform.Translate( x, 0f, y );
    }
}
