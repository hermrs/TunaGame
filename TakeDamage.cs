using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{
    public int Damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "engel")
        {
            print("col detected");
            GameObject.Find("Player").GetComponent<CharacterControllerC>().Carban -= Damage;
        }
        if (other.gameObject.tag == "lav")
        {
            print("col detected");
            GameObject.Find("Player").GetComponent<CharacterControllerC>().Carban = 0;
        }
    }
}
