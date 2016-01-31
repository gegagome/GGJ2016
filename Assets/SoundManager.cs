using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioClip[] effectsList;
    public AudioClip[] bgList;
    public AudioSource effects;
    public AudioSource bg;
    public void playEffect(AudioClipSymbol symbol)
    {
        switch (symbol)
        {
            case AudioClipSymbol.AnnCD1:
                effects.clip = effectsList[0];
                break;
            case AudioClipSymbol.AnnCD2:
                effects.clip = effectsList[1];
                break;
            case AudioClipSymbol.AnnCD3:
                effects.clip = effectsList[2];
                break;
            case AudioClipSymbol.AnnCD4:
                effects.clip = effectsList[3];
                break;
            case AudioClipSymbol.AnnGoal:
                effects.clip = effectsList[4];
                break;
            case AudioClipSymbol.AnnLv1:
                effects.clip = effectsList[5];
                break;
            case AudioClipSymbol.AnnLv2:
                effects.clip = effectsList[6];
                break;
            case AudioClipSymbol.AnnLv3:
                effects.clip = effectsList[7];
                break;
            case AudioClipSymbol.AnnLv4:
                effects.clip = effectsList[8];
                break;
            case AudioClipSymbol.AnnRun:
                effects.clip = effectsList[9];
                break;
            case AudioClipSymbol.PlayerDeath1:
                effects.clip = effectsList[10];
                break;
            case AudioClipSymbol.PlayerDeath2:
                effects.clip = effectsList[11];
                break;
            case AudioClipSymbol.PlayerDeath3:
                effects.clip = effectsList[12];
                break;
            case AudioClipSymbol.PlayerDeath4:
                effects.clip = effectsList[13];
                break;
            case AudioClipSymbol.PlayerHit1:
                effects.clip = effectsList[14];
                break;
            case AudioClipSymbol.PlayerHit2:
                effects.clip = effectsList[15];
                break;
            case AudioClipSymbol.PlayerHit3:
                effects.clip = effectsList[16];
                break;
            case AudioClipSymbol.PlayerJump1:
                effects.clip = effectsList[17];
                break;
            case AudioClipSymbol.PlayerJump2:
                effects.clip = effectsList[18];
                break;
            case AudioClipSymbol.PlayerJump3:
                effects.clip = effectsList[19];
                break;
            case AudioClipSymbol.PlayerJump4:
                effects.clip = effectsList[20];
                break;
            case AudioClipSymbol.PlayerJump5:
                effects.clip = effectsList[21];
                break;
            case AudioClipSymbol.PlayerJump6:
                effects.clip = effectsList[22];
                break;
            default:
                break;
        }
    }

    public void playBackground(BackgroundAudio symbol)
    {
        switch (symbol)
        {
            case BackgroundAudio.DeathStinger:
                effects.clip = bgList[0];
                break;
            case BackgroundAudio.Level1Loop:
                effects.clip = bgList[1];
                break;
            case BackgroundAudio.MainTitle:
                effects.clip = bgList[2];
                break;
            case BackgroundAudio.Victory:
                effects.clip = bgList[3];
                break;
            default:
                break;
        }
    }
}

public enum AudioClipSymbol {
    AnnCD1, AnnCD2, AnnCD3, AnnCD4, AnnGoal, AnnLv1, AnnLv2, AnnLv3, AnnLv4,
    AnnRun, PlayerDeath1, PlayerDeath2, PlayerDeath3, PlayerDeath4,
    PlayerHit1, PlayerHit2, PlayerHit3, PlayerJump1, PlayerJump2, PlayerJump3, PlayerJump4,
    PlayerJump5, PlayerJump6
}

public enum BackgroundAudio
{
    DeathStinger, Level1Loop, MainTitle, Victory, Level2Loop
}