using UnityEngine;

public class EnemySound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundClip; // Le son spécifique à cet ennemi
    public float maxVolumeDistance = 10f; // Distance à partir de laquelle le son est au volume maximum

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        if (distanceToPlayer <= maxVolumeDistance)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();

            audioSource.volume = 1 - (distanceToPlayer / maxVolumeDistance);
        }
        else
        {
            audioSource.Stop();
        }
    }
}
