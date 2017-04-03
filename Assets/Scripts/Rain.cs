using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rain : MonoBehaviour
{

    [SerializeField] private RainParticle[] rainParticles = new RainParticle[6];

    [Range(0.0f, 1.0f)]
    [SerializeField] private float rainIntensity;
    private float rainRate = 1.0f;

    // Update is called once per frame
    void Update()
    {
        ChangeRain();
        //rainIntensity *= 0.999f;
    }

    void ChangeRain(){
        foreach (RainParticle p in rainParticles)
        {
            var emission = p.particles.emission;
            switch (p.name)
            {
                case "Rain Sheet 2":
                    if (rainIntensity < 0.5f)
                    {
                        emission.enabled = false;
                    }
                    else if (!emission.enabled)
                    {
                        emission.enabled = true;
                    }
                    break;
                case "Rain Sheet":
                    if (rainIntensity < 0.05f)
                    {
                        emission.enabled = false;
                    }
                    else if (!emission.enabled)
                    {
                        emission.enabled = true;
                    }
                    break;
                default:
                    break;
            }
            emission.rateOverTime = p.initialRate * rainIntensity;
        }
    }

    public float RainIntensity {
        get { return rainIntensity; }
        set {
            if (value < 0.0f)
            {
                rainIntensity = 0.0f;
            }
            else if (value > 1.0f)
            {
                rainIntensity = 1.0f;
            }
            else
            {
                rainIntensity = value;
            }
        }
    }
}