using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPower : MonoBehaviour
{
    public float increase = 3f;
    [SerializeField] private AudioClip pickupsound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();

            if (playerMovement)
            {
                SoundManager.instance.PlaySound(pickupsound);
                playerMovement.speed += increase;
                Destroy(gameObject);
            }


        }
    }


}
