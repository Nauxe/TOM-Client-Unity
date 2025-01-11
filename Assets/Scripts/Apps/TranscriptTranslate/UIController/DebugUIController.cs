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

    public class DebugUIController : MonoBehaviour
    {
        [SerializeField] private GameObject TemplateUI;
        [SerializeField] private TextMesh panelText;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void ResetUI()
        {
            Debug.Log("ResetUI");
            UpdateText("");
        }

        public void UpdateText(string text)
        {
            panelText.text = text;
        }

    }

}
