using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    private Rigidbody rg;
    public TMP_Text m_time, m_health, m_state;
    public Button m_button;
    public Image m_stateBG;
    private float velocityFactor = 1.5f;
    private float timeCounter = 20;
    private int healthCounter = 3;
    private bool inGame = true, isSucceed = false;

    // Start is called before the first frame update
    void Start()
    {
        m_state.gameObject.SetActive( false );
        m_stateBG.gameObject.SetActive( false );
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if( inGame && !isSucceed )
        {
            timeCounter -= Time.deltaTime;
            m_time.text = "Time: " + Convert.ToInt32( timeCounter ).ToString();
        }
        
        
        if( timeCounter < 0 && inGame )
        {
            m_state.text = "Time is out";
            m_state.gameObject.SetActive( true );
            m_stateBG.gameObject.SetActive( true );
            m_button.gameObject.SetActive( true );
            rg.velocity = Vector3.zero;
            rg.angularVelocity = Vector3.zero;
            inGame = false;
        }
    }

    public void FixedUpdate()
    {
        if( inGame && !isSucceed )
        {
            float horizontal = Input.GetAxis( "Horizontal" );
            float vertical = Input.GetAxis( "Vertical" );

            Vector3 force = new Vector3( vertical, 0, -horizontal );
            rg.AddForce( force * velocityFactor );
        }
        else if( !isSucceed )
        {
            //If you are not in Game, set velocity 0 to not move the ball
            rg.velocity = Vector3.zero;
            rg.angularVelocity = Vector3.zero;
        }
    }

    public void OnCollisionEnter( Collision collision )
    {
        string obj = collision.gameObject.name;
        
        if( collision.gameObject.tag == "Final" ) 
        {
            isSucceed = true;
            m_state.text = "You win";
            m_state.gameObject.SetActive( true );
            m_stateBG.gameObject.SetActive( true );
            m_button.gameObject.SetActive( true );
        }
        else if( collision.gameObject.tag == "Obstacle" )
        {
            healthCounter -= 1;
            m_health.text = healthCounter.ToString();

            if( healthCounter == 0 )
            {
                m_state.text = "Game over";
                m_state.gameObject.SetActive( true );
                m_stateBG.gameObject.SetActive( true );
                m_button.gameObject.SetActive( true );

                rg.velocity = Vector3.zero;
                rg.angularVelocity = Vector3.zero;
                isSucceed = false;
                inGame = false;
            }
        }
    }
}
