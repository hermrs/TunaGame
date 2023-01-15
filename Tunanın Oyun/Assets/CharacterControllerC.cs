using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControllerC : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] public GameObject character;
    [SerializeField] public int Carban;
    private Rigidbody rigitBody;
    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"),0);
        characterController.Move(move * Time.deltaTime * Carban);
        // jump alt
       
        
    }
   
}
