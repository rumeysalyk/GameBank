using UnityEngine;

public class StarCreation : MonoBehaviour
{
    public GameObject star;
    private GameObject obj;
    public GameObject m_starParent;

    private float m_creationTime = 2f;
    private float m_timeCounter = 0f;

    TMPro.TextMeshProUGUI m_numberText;
    public int level;


    void Start()
    {
        obj = Instantiate(star, new Vector3(Random.Range( 115, Screen.width - 115 ), Random.Range( -145, Screen.height ), 0), Quaternion.identity, m_starParent.transform);

        m_numberText = obj.GetComponentInChildren<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        m_timeCounter -= Time.deltaTime;
        if ( m_timeCounter < 0 )
        {
            m_numberText.SetText(Random.Range(10, 50).ToString());


            float x = Random.Range(115, Screen.width-115);
            float y = Random.Range(115, Screen.height - 115);


            obj.transform.position = new Vector3(x, y, 0);
            m_timeCounter = m_creationTime;
        }
    }


}
