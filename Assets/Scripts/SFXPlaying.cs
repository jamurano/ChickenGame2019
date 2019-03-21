using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource ChickenButtonSound;

    public void PlayChickenButtonSound() {
        ChickenButtonSound.Play();       
    }
}
