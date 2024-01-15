using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject FiendeSkott;
    public Transform SkottPos;
    private GameObject player; 

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        if(distance < 20)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

    }
        
    void shoot()
    {
        Instantiate(FiendeSkott, SkottPos.position, Quaternion.identity);
    }

}
