using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound{

	public string name;
	public AudioClip clip;
	public AudioMixerGroup mixerGroup;

	[Range(-40f,10f)]
	public float volume;
	[Range(.95f,1.05f)]
	public float pitch;

	public bool loop = false;
	public bool playOnAwake = false;
	public void SetSource(AudioSource mySource)
	{
		source = mySource;
		source.clip = clip;
		source.pitch = pitch;
		source.volume = volume;
		source.playOnAwake = playOnAwake;
		source.loop = loop;
		source.outputAudioMixerGroup = mixerGroup;
	}
	public void Play()
	{
		source.Play();
	}
	[HideInInspector]
	public AudioSource source;
}
