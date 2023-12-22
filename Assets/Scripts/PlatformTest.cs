using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformTest : MonoBehaviour
{
    public static PlatformTest Instance;

    private static string configPath = "Assets/Resources/config.json";
    private ConfigData configData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // 检查config.json文件是否存在，不存在则创建并设置默认值  
        if (!File.Exists(configPath))
        {
            configData = new ConfigData();
            configData.isVR = false; // 默认非VR环境  
            SaveConfigData();
        }
        else
        {
            LoadConfigData();
        }
    }

    private void SaveConfigData()
    {
        string json = JsonUtility.ToJson(configData);
        File.WriteAllText(configPath, json);
    }

    private void LoadConfigData()
    {
        string json = File.ReadAllText(configPath);
        configData = JsonUtility.FromJson<ConfigData>(json);
        ScenceLoad();
    }


    private void ScenceLoad()
    {
        if (configData.isVR)
        {
            // 进入VR场景  
            SceneManager.LoadScene(1);

        }
        else
        {
            // 进入PC场景  
            SceneManager.LoadScene(2);
        }
    }
}

[Serializable]
public class ConfigData
{
    public bool isVR = false; // 是否为VR环境标志位    
}
