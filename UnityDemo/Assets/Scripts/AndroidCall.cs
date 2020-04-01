using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidCall : MonoBehaviour
{
    public Text target;

    void Start() {
        // try to get android class
        AndroidJavaObject bridge = new AndroidJavaObject("edu.brown.mpmhplugin.MPMHPlugin");
        Debug.Log("Unity Bridge:" + bridge);
        string rettext = bridge.Call<string>("test");
        Debug.Log("Unity Get test:" + rettext);
        target.text = rettext;
    }
}
