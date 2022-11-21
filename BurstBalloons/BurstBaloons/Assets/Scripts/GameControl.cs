using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public TMP_Text TimerCount, BalloonCount;
    public GameObject m_burstingAllBalloons;
    public float Timer = 60f;
    private int m_burstedBalloon = 0;



    // Start is called before the first frame update
    void Start()
    {
        BalloonCount.text = "BALLOON : " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        if( Timer > 0 )
        {
            Timer -= Time.deltaTime;
            TimerCount.text = "TIME : " + Convert.ToInt32( Timer ).ToString();
        }
        else
        {
            GameObject[] balloons = GameObject.FindGameObjectsWithTag( "Balloon" );
            
            for( int i = 0; i < balloons.Length; i++ )
            {
                Instantiate( m_burstingAllBalloons, balloons[i].transform.position, balloons[i].transform.rotation );
                Destroy( balloons[i] );   
            }

            SceneManager.LoadScene( "IntroScene" ); 
        }
    }

    public void AddBalloon()
    {
        m_burstedBalloon += 1;
        BalloonCount.text = "BALLOON : " + Convert.ToInt32( m_burstedBalloon ).ToString();
    }
}
