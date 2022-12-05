using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMorals : MonoBehaviour
{
    public int Morality = 0;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Question1;

    public GameObject Button3;
    public GameObject Button4;
    public GameObject Question2;

    public GameObject Button5;
    public GameObject Button6;
    public GameObject Question3;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Button1") || Other.gameObject.CompareTag("Button2"))
        {
            Morality = Question_One(Other, Morality);
            
            Destroy(Button1);
            Destroy(Button2);
            Destroy(Question1);
        }
        else if(Other.gameObject.CompareTag("Button3")|| Other.gameObject.CompareTag("Button4"))
        {
            Morality = Question_Two(Other, Morality);

            Destroy(Button3);
            Destroy(Button4);
            Destroy(Question2);
        }
        else if(Other.gameObject.CompareTag("Button5")|| Other.gameObject.CompareTag("Button6"))
        {
            Morality = Question_Two(Other, Morality);

            Destroy(Button5);
            Destroy(Button6);
            Destroy(Question3);
        }
        else
        {
            Transition();
        }
    }

    public int Question_One(Collider Other, int Moarlity)
    {
        if(Other.CompareTag("Button1"))
        {
            Morality--;
            return Morality;
        }
        else if(Other.CompareTag("Button2"))
        {
            Morality++;
            return Morality;
        }
        else
        {
            return Morality;
        }
    }

    public int Question_Two(Collider Other, int Morality)
    {
        if (Other.CompareTag("Button3"))
        {
            Morality++;
            return Morality;
        }
        else if (Other.CompareTag("Button4"))
        {
            Morality--;
            return Morality;
        }
        else
        {
            return Morality;
        }
    }

    public int Question_Three(Collider Other, int Morality)
    {
        if (Other.CompareTag("Button5"))
        {
            Morality++;
            return Morality;
        }
        else if (Other.CompareTag("Button6"))
        {
            Morality--;
            return Morality;
        }
        else
        {
            return Morality;
        }
    }

    public void Transition()
    {
        if(Morality >= -3 && Morality <=-1)
        {

        }
        else if(Morality > -1 && Morality < 1)
        {

        }
        else if(Morality <= 1 && Morality <= 3)
        {

        }
        else
        {
            SceneManager.LoadScene("");
            SceneManager.UnloadScene("");
        }
    }
}
