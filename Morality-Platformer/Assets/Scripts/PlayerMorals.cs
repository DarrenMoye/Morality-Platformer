using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMorals : MonoBehaviour
{
    public int Morality = 0;

    public GameObject Player;
    public float Player_X;

    int Rand;

    public GameObject Selfish_Button;
    public GameObject Selfless_Button;
    public GameObject Question1;

    private int Update()
    {
        Player_X = Player.transform.position.x;
        Rand = ((int)Player_X) % 2;
        
        return Rand;
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Selfish_Button") || Other.gameObject.CompareTag("Selfless_Button"))
        {
            Morality = SelfishvsSelfless(Other, Morality);
            
            Destroy(Selfish_Button);
            Destroy(Selfless_Button);
            Destroy(Question1);
        }
        


    }

    public int SelfishvsSelfless(Collider Other, int Moarlity)
    {
        if(Other.CompareTag("Selfish_Button"))
        {
            Morality--;
            return Morality;
        }
        else if(Other.CompareTag("Selfless_Button"))
        {
            Morality++;
            return Morality;
        }
        else
        {
            return Morality;
        }
    }
}
