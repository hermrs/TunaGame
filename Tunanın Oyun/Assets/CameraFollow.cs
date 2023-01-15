using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public GameObject player;
    private float offsets;
    private float offsetsSmoot;
    private Vector3 playerPosi;
    // Start is called before the first frame update
    void Start()
    {
        offsets = 5;
        offsetsSmoot = 2;
    }

    // Update is called once per frame
    void Update()
    {
       playerPosi = new Vector3(player.transform.position.x  , player.transform.position.y   , transform.position.z); ;
       if(player.transform.localScale.x > 0f)
        {
            playerPosi = new Vector3(playerPosi.x + offsets, playerPosi.y, playerPosi.z);

        }
        else
        {
            playerPosi = new Vector3(playerPosi.x - offsets, playerPosi.y, playerPosi.z);
        }
        transform.position = Vector3.Lerp(transform.position, playerPosi, offsetsSmoot * Time.deltaTime); ;
    }
}
