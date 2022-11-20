using UnityEngine;

public class BaloonCreation : MonoBehaviour
{
    public GameObject m_balloon;

    private float m_creationFreq = 1f;
    private float m_timer = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        m_timer -= Time.deltaTime;

        if( m_timer < 0 )
        {
            var baloon = Instantiate( m_balloon, new Vector3(Random.Range(-2.4f, 2.4f), -5.5f, 0), Quaternion.Euler(0, 0, 0) ) as GameObject;
            baloon.GetComponent<Rigidbody2D>().AddForce( new Vector2(0f, Random.Range(30f, 90f) ) );        
            m_timer = m_creationFreq;
        }
    }

}
