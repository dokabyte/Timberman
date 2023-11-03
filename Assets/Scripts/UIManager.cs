using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Awake()
    {
        playButton.onClick.AddListener(GoToGameScene);
    }

    public void GoToGameScene()
    {
        GameSystem.instance.PlaySFXAudioByType(SFXAudioType.OnClick);
        SceneManager.LoadScene("sGame");
        GameSystem.instance.PlayEnviromentAudioByType(EnviromentAudioType.Gameplay);
    }
}
