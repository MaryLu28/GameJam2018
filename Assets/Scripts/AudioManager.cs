using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public Sound[] backgroundmusic;
	public AudioSource effects;
	public AudioSource voice;

	public static AudioManager instance; 

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);

		foreach (Sound s in backgroundmusic)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}		
	}
	
	void Start() //Inicia al comenzar. Probablemente necesite añadirlo a la escena de alguna forma
	{
		PlayMusic("Menu");
	}

	public void PlayEffect(AudioClip clip)
	{
		effects.clip = clip;
		effects.Play();
	}

	public void PlayMusic (string name)
	{
		Sound s = Array.Find(backgroundmusic, SoundManager => SoundManager.name == name);
		if (s == null)	
		{
			Debug.LogWarning("Sound " + name + " is missing");
			return;
		}	
		s.source.Play();
			
	}	
}
