using UnityEngine;

public class BaloonControl : MonoBehaviour
{
    public GameObject m_bursting;
    private GameControl m_gameControl;

    public void Start()
    {
        m_gameControl = GameObject.Find( "BalloonCreation" ).GetComponent<GameControl>();
    }

    public void OnMouseDown()
    {
        var bursting = Instantiate( m_bursting, transform.position, transform.rotation );
        Destroy( this.gameObject );//
        Destroy( bursting, 0.6f );
        m_gameControl.AddBalloon();
    }
}
