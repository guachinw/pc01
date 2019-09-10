using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;

    Vector3 steer = Vector3.zero;
    float maxSpeed = 5;
    float maxSteer = 10;

    Transform goal;

    Transform target;
    void Start()
    {
        goal = GameObject.Find("Goal").transform;
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Target").transform;

        //desired/deseado
        desired = -(target.position - transform.position).normalized * maxSpeed; 
        steer = Vector3.ClampMagnitude(desired - velocity, maxSteer);

        velocity += steer * Time.deltaTime; //direccion
        transform.position += velocity * Time.deltaTime;

        float dist = Vector3.Distance(goal.position, transform.position);

        if(dist <= 1f)
        {
            Debug.Log("Win");
            Destroy(gameObject);
        }
        else if (transform.position.x >= 10 || transform.position.x <= -10){
            Debug.Log("Lose");
            Destroy(gameObject);
        }

        else if (transform.position.y >= 5 || transform.position.y <= -5){
            Debug.Log("Lose");
            Destroy(gameObject);
        }


    }
    void OnBecameInvinsible()
    {
        Debug.Log("Lose");
        Destroy(gameObject);
    }
}
