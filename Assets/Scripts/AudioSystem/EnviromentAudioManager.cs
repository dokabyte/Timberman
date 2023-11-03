using UnityEngine;

public enum EnviromentAudioType
{
    Menu,
    Gameplay,
    GameOver
}

public class EnviromentAudioManager : AudioABS
{
    public void PlaySoundByType(EnviromentAudioType audioType)
    {
        switch (audioType)
        {
            case EnviromentAudioType.Menu:
                PlaySound(audioClips[0]);
                break;

            case EnviromentAudioType.Gameplay:
                PlaySound(audioClips[1]);
                break;

            case EnviromentAudioType.GameOver:
                PlaySound(audioClips[2]);
                break;
        }
    }
}
