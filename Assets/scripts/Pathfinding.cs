using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{

    public Transform[] player;

    private NavMeshAgent nav;
    private int destPoint;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {    
        if (!nav.pathPending && nav.remainingDistance < 20.0f)
            GoToNextPoint();
        
  	        
    }

    void GoToNextPoint()
    {
  	    if (player.Length == 0)
  	    {
  		    return;
  	    }
  	    nav.destination = player[destPoint].position;
  	    destPoint = (destPoint + 1) % player.Length;
    }
}
