using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    [HideInInspector] public InputManager inputManager;

    [SerializeField] private AudioSystem audioSystem;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        inputManager = new InputManager();

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        PlayEnviromentAudioByType(EnviromentAudioType.Menu);
    }

    public void PlayEnviromentAudioByType(EnviromentAudioType audioType)
    {
        audioSystem.PlayEnviromentAudioByType(audioType);
    }

    public void PlaySFXAudioByType(SFXAudioType audioType)
    {
        audioSystem.PlaySFXAudioByType(audioType);
    }
}
