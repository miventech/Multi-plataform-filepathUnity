using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

public static class fileManagerTools : MonoBehaviour
{

    public static string getPathRootXML()
    {
#if UNITY_EDITOR
        string path = Application.dataPath + "/FILES_XML/";
        string path1 = Application.dataPath + "/FILES_XML";
        if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        return path;

#elif UNITY_ANDROID
        
         string path = Application.persistentDataPath + "/FILES_XML/";
        string path1 = Application.persistentDataPath + "/FILES_XML";
        if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        return path;
#elif UNITY_IPHONE
        
        string path = Application.persistentDataPath + "/FILES_XML/";
        string path1 = Application.persistentDataPath + "/FILES_XML";
        if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        return path;
#else
        string path = Application.dataPath + "/FILES_XML/";
        string path1 = Application.dataPath + "/FILES_XML";
        if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        return path;

#endif
    }


}   
