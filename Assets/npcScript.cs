using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcScript : MonoBehaviour {

    public GameObject alvo;
    public float velocidade = 30;
    
 
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, alvo.transform.position, velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            Destroy(collider.gameObject);
        }
    }
}
