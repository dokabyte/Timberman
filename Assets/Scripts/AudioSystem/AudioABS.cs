using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class AudioABS : MonoBehaviour
{
    [SerializeField] protected AudioClip[] audioClips;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    protected void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }
}
