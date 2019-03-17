using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public Camera cam; //reference to camera \
    public NavMeshAgent agent; //reference to player/agent
    public ThirdPersonCharacter character;

    void Start()
    {
        agent.updateRotation = false;
    }
    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit; //variable that stores what the ray hits

            if (Physics.Raycast(ray, out hit)) // if the ray hits something will move our player/agent
            {
                agent.SetDestination(hit.point);//move player or agent
            }
        }
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false); // dont want to crouch or jump = false
        }
        else
        {
            character.Move(Vector3.zero, false, false); //stop moving
        }
      
    }
}
