using UnityEngine;


public class Player_Prefs 
{

    public void SetInt(string key,int value)
    {
        PlayerPrefs.SetInt(key,value);
    }
    public void SetFloat(string key,float value)
    {
        PlayerPrefs.SetFloat(key,value);
    }
    public void SetString(string key,string value)
    {
        PlayerPrefs.SetString(key,value);
    }
    
    public int GetInt(string key)
    {
        return PlayerPrefs.GetInt(key);
    }
    public float GetFloat(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }
    public string GetString (string key)
    {
        return PlayerPrefs.GetString(key);
    }
}

