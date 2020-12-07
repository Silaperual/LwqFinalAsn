using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWheelParticle : MonoBehaviour
{
    public GameObject[] trailObj;
    private int trailIndex;
    private GameObject rainbowObj;
    // Start is called before the first frame update
    void Start()
    {
        rainbowObj = trailObj[2].transform.Find("RainbowTrail").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            trailIndex = 0;
            foreach (GameObject item in trailObj)
            {
                if (item.GetComponent<ParticleSystem>().isPlaying == true)
                {
                    item.GetComponent<ParticleSystem>().Stop();
                    if (rainbowObj != null)
                    {
                        rainbowObj.SetActive(false);
                    }
                };
            }
            trailObj[trailIndex].GetComponent<ParticleSystem>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            trailIndex = 1;
            foreach (GameObject item in trailObj)
            {
                if (item.GetComponent<ParticleSystem>().isPlaying == true)
                {
                    item.GetComponent<ParticleSystem>().Stop();
                    if (rainbowObj != null)
                    {
                        rainbowObj.SetActive(false);
                    }
                };
            }
            trailObj[trailIndex].GetComponent<ParticleSystem>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            trailIndex = 2;
            foreach (GameObject item in trailObj)
            {
                if (item.GetComponent<ParticleSystem>().isPlaying == true)
                {
                    item.GetComponent<ParticleSystem>().Stop();
                };
            }
            trailObj[trailIndex].GetComponent<ParticleSystem>().Play();
            if (rainbowObj != null)
            {
                rainbowObj.SetActive(true);
            }
        }

    }
}
