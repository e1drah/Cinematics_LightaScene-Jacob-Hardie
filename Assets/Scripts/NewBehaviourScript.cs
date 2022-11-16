using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector timeline1;
    public PlayableDirector timeline2;

    public MeshRenderer mesh;

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
                    Debug.Log("No keys left");
                    break;
                default:
                    timeline2.Play();

                    if (OneTimeTrigger == true)
                    {
                        Destroy(this.gameObject);
                    }
                    Debug.Log("Some keys left");
                    break;
            }

        }
    }
    public void KeyMinus()
    {
        keys -= 1;
        Debug.Log(keys);
    }
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MeshDisable()
    {
        mesh.enabled = false;
    }
}
