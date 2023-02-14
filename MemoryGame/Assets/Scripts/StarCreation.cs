using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StarCreation : MonoBehaviour
{
    public GameObject star;
    private GameObject obj;
    public GameObject m_starParent;
    public Image m_dialog;
    TMPro.TextMeshProUGUI m_numberText;
    public int level;


    void Start()
    {
        obj = Instantiate(star, new Vector3(Random.Range( 115, Screen.width - 115 ), Random.Range( -145, Screen.height ), 0), Quaternion.identity, m_starParent.transform);
        m_numberText = obj.GetComponentInChildren<TMPro.TextMeshProUGUI>();

        startGame();
    }

    public void startGame()
    {
        level = 1;

        StartCoroutine( showStars( level + 1 ) );
    }


    private IEnumerator showStars( int i )
    {
        while( i > 0 )
        {
            m_numberText.SetText( Random.Range( 10, 50 ).ToString() );

            float x = Random.Range( 115, Screen.width - 115 );
            float y = Random.Range( 115, Screen.height - 115 );

            obj.transform.position = new Vector3( x, y, 0 );
            Debug.Log(i);
            yield return new WaitForSeconds( 1f );
            i--;
        }
        m_dialog.gameObject.SetActive( true );
        StopCoroutine( showStars( level + 1 ) );    
        Time.timeScale = 0;
        level++;
        StartCoroutine( showStars( level + 1 ) );
    }
}
