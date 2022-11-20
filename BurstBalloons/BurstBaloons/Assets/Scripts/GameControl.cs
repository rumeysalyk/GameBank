using System;
using TMPro;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public TMP_Text m_timerCount, m_balloonCount;
    public GameObject m_burstingAllBalloons;
    private int m_burstedBalloon = 0;
    public float m_timer = 5f;


    // Start is called before the first frame update
    void Start()
    {
        m_balloonCount.text = "BALLOON : " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        if( m_timer > 0 )
        {
            m_timer -= Time.deltaTime;
            m_timerCount.text = "TIME : " + Convert.ToInt32( m_timer ).ToString();
        }
        else
        {
            GameObject[] balloons = GameObject.FindGameObjectsWithTag( "Balloon" );
            
            for( int i = 0; i < balloons.Length; i++ )
            {
                Instantiate( m_burstingAllBalloons, balloons[i].transform.position, balloons[i].transform.rotation );
                Destroy( balloons[i] );   
            }
        }
    }

    public void AddBalloon()
    {
        m_burstedBalloon += 1;
        m_balloonCount.text = "BALLOON : " + Convert.ToInt32( m_burstedBalloon ).ToString();
    }
}
