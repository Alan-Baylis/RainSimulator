using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainParticle : MonoBehaviour {
    public ParticleSystem particles;
    public float initialRate;

    void Awake(){
        particles = GetComponent<ParticleSystem>();
        initialRate = particles.emission.rateOverTimeMultiplier;
    }
}
