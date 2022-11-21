using UnityEngine;

public class BaloonCreation : MonoBehaviour
{
    public GameObject m_balloon;
    private GameControl m_gameControl;

    private float m_creationFreq = 1f;
    private float m_timer = 0f;

    void Start()
    {
        m_gameControl = this.gameObject.GetComponent<GameControl>();    
    }


    void Update()
    {
        m_timer -= Time.deltaTime;
        int velocityFactory = (int) ( m_gameControl.Timer /10 ) -6;

        velocityFactory *= -1;
        if( m_timer < 0 && m_gameControl.Timer > 0 )
        {
            var baloon = Instantiate( m_balloon, new Vector3(Random.Range(-2.4f, 2.4f), -5.5f, 0), Quaternion.Euler(0, 0, 0) ) as GameObject;
            baloon.GetComponent<Rigidbody2D>().AddForce( new Vector2(0f, Random.Range(30f*velocityFactory, 90f* velocityFactory ) ) );        
            m_timer = m_creationFreq;
        }

    }

} 
