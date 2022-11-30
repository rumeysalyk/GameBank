using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float sensivity = 5f;
    private float softness = 2f;

    Vector2 transitionPosition;
    Vector2 cameraPosition;

    GameObject user;
    // Start is called before the first frame update
    void Start()
    {
        user = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = new Vector2( Input.GetAxis( "Mouse X"), Input.GetAxis( "Mouse Y" ) ) ;

        mousePos = Vector2.Scale( mousePos, new Vector2( sensivity*softness, sensivity*softness ));
        transitionPosition.x = Mathf.Lerp( transitionPosition.x, mousePos.x, 1f/softness );
        transitionPosition.y = Mathf.Lerp( transitionPosition.y, mousePos.y, 1f/softness );

        cameraPosition += transitionPosition;

        transform.localRotation = Quaternion.AngleAxis( cameraPosition.y, Vector3.right );

        user.transform.localRotation = Quaternion.AngleAxis( cameraPosition.x, user.transform.up );
    }
}
