﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WorldBuilder
{
    public class BuildButton : MonoBehaviour
    {
        public GameObject tile;

        // Use this for initialization
        void Start()
        {
            Button btn = gameObject.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            CameraManager cameraMan = Camera.main.GetComponent<CameraManager>();
            cameraMan.EnterBuildMode(tile);
        }
    }
}