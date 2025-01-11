using TOM.Common.UI;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using System.IO;

using Microsoft.MixedReality.Toolkit.Audio;


namespace TOM.Apps.Template
{

    public class TransUIController : MonoBehaviour
    {
        [SerializeField] private GameObject TemplateUI;
        [SerializeField] private TextMesh panelText;
        [SerializeField] private TextMesh translatedText;
        [SerializeField] private AudioSource audioSource;
        private string previousAudio;

        // Start is called before the first frame update
        void Start()
        {
            previousAudio = "";
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void ResetUI()
        {
            UpdateText("");
            UpdateTranslatedText("");
            audioSource.Stop();
        }

        public void UpdateText(string text)
        {
            panelText.text = text;
        }

        public void UpdateTranslatedText(string text)
        {
            translatedText.text = text;
        }



        public void PlayAudio(string audioName)
        {
            Debug.Log("PlayAudio");
            // Guard clause to prevent same audio from replaying prematurely
            if (previousAudio == audioName && audioSource.isPlaying)
            {
                return;
            }

            audioSource.Stop();
            AudioClip clip = LoadAudioClip(audioName);
            audioSource.clip = clip;
            audioSource.Play();
        }

        private AudioClip LoadAudioClip(string audioName)
        {
            // Instructions for new users: songs and soundtracks should all sit in the Assets/Resources/Audio folder by convention
            string path = "Audio/" + audioName;
            AudioClip audioClip = Resources.Load<AudioClip>(path);
            if (audioClip == null)
            {
                Debug.LogError("Failed to load audio clip from path: " + path);
                return null;
            }

            Debug.Log("Successfully loaded clip from path: " + path);
            return audioClip;
        }
    }

}
