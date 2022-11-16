using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector timeline1;
    public PlayableDirector timeline2;

    public int keys;
    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            switch (keys)
            {
                case 0:
                    timeline1.Play();

                    if (OneTimeTrigger == true)
                    {
                        Destroy(this.gameObject);
                    }
                    break;
                default:
                    timeline2.Play();

                    if (OneTimeTrigger == true)
                    {
                        Destroy(this.gameObject);
                    }
                    break;
            }

        }
    }
    public void KeyMinus()
    {
        keys--;
    }
}
