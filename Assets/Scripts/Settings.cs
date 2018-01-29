using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {

	public AudioMixer audioMixer;
	public void SetVolumeMaster (float volume)
	{
		audioMixer.SetFloat("Master", volume);
	}
	public void SetVolumeMusic(float volume)
	{
		audioMixer.SetFloat("Music", volume);
	}
	public void SetVolumeEffects(float volume)
	{
		audioMixer.SetFloat("Effects", volume);
	}
	public void SetVolumeNarrator(float volume)
	{
		audioMixer.SetFloat("Narrator", volume);
	}
}
