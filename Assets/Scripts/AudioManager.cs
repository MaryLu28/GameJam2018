using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

	public Sound[] sound;
	public static AudioManager instance;

	// Use this for initialization
	void Awake() {
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);
	}
	public void Play(string clipName)
	{
		for (int i = 0; i < sound.Length; i++)
		{
			if (sound[i].name == clipName)
			{
				sound[i].Play();
				return;
			}
		}
	}
	public void Stop(string clipName)
	{
		for (int i = 0; i < sound.Length; i++)
		{
			if (sound[i].name == clipName)
			{
				sound[i].Stop();
				return;
			}
		}
	}

	void Start()
	{
		for (int i = 0; i < sound.Length; i++)
		{
			GameObject _go = new GameObject("Sound" + i + "_" + sound[i].name);
			_go.transform.SetParent(this.transform);
			sound[i].SetSource(_go.AddComponent<AudioSource>());
		}
		Play("Menu");
	}

}
