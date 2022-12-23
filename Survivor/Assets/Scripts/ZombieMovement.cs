using UnityEngine;
using UnityEngine.AI;
public class ZombieMovement : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find( "FPSController" );
    }

    // Update is called once per frame  
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
    }
}
