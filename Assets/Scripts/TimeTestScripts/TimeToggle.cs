using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour
{
    /// <summary>
    /// https://freesound.org/people/n-lerche/sounds/459618/
    /// https://retired.sounddogs.com/sound-effects/slow-motion-doppler-efx-965440
    /// https://freesound.org/people/13GPanska_Lakota_Jan/sounds/378355/
    /// </summary>
    public AudioClip slowToNormal;
    public AudioClip normalToSlow;

    AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER TIME CHANGE");
        if(other.gameObject.tag == "TimeToggle")
        {
            if(TimeManager.instance.slowMotion == true)
            {
                TimeManager.instance.slowMotion = false;
                source.pitch = 1;
                source.PlayOneShot(slowToNormal);
            }
            else
            {
                TimeManager.instance.slowMotion = true;
                source.pitch = 2;
                source.PlayOneShot(normalToSlow);

            }
        }
    }
}
