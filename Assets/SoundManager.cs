using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioClip[] effectsList;
    public AudioClip[] bgList;
    public AudioSource effects;
    public AudioSource bg;


	void Start()
	{
		Debug.Log ("please");

		Utilities.blAH = this;
		Debug.Log ("ascbnsjcnksjnckjsdncks");

	}
    public void playEffect(AudioClipSymbol symbol)
    {
        switch (symbol)
        {
            case AudioClipSymbol.AnnCD1:
                effects.clip = effectsList[0];
                effects.Play();
                break;
            case AudioClipSymbol.AnnCD2:
                effects.clip = effectsList[1];
                effects.Play();
                break;
            case AudioClipSymbol.AnnCD3:
                effects.clip = effectsList[2];
                effects.Play();
                break;
            case AudioClipSymbol.AnnCD4:
                effects.clip = effectsList[3];
                effects.Play();
                break;
            case AudioClipSymbol.AnnGoal:
                effects.clip = effectsList[4];
                effects.Play();
                break;
            case AudioClipSymbol.AnnLv1:
                effects.clip = effectsList[5];
                effects.Play();
                break;
            case AudioClipSymbol.AnnLv2:
                effects.clip = effectsList[6];
                effects.Play();
                break;
            case AudioClipSymbol.AnnLv3:
                effects.clip = effectsList[7];
                effects.Play();
                break;
            case AudioClipSymbol.AnnLv4:
                effects.clip = effectsList[8];
                break;
            case AudioClipSymbol.AnnRun:
                effects.clip = effectsList[9];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerDeath1:
                effects.clip = effectsList[10];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerDeath2:
                effects.clip = effectsList[11];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerDeath3:
                effects.clip = effectsList[12];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerDeath4:
                effects.clip = effectsList[13];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerHit1:
                effects.clip = effectsList[14];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerHit2:
                effects.clip = effectsList[15];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerHit3:
                effects.clip = effectsList[16];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump1:
                effects.clip = effectsList[17];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump2:
                effects.clip = effectsList[18];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump3:
                effects.clip = effectsList[19];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump4:
                effects.clip = effectsList[20];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump5:
                effects.clip = effectsList[21];
                effects.Play();
                break;
            case AudioClipSymbol.PlayerJump6:
                effects.clip = effectsList[22];
                effects.Play();
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
                bg.clip = bgList[0];
                bg.Play();
                break;
            case BackgroundAudio.Level1Loop:
                bg.clip = bgList[1];
                bg.Play();
                break;
            case BackgroundAudio.MainTitle:
                bg.clip = bgList[2];
                bg.Play();
                break;
            case BackgroundAudio.Victory:
                bg.clip = bgList[3];
                bg.Play();
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