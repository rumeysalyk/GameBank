using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var left = Input.GetKeyDown( KeyCode.LeftArrow );
        var right = Input.GetKeyDown( KeyCode.RightArrow );
    }
}
