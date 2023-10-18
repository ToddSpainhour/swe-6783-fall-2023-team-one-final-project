using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    

    
    [SerializeField] private Slider volumeSlider;


    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            
            PlayerPrefs.SetFloat("musicVolume", 0.5f);
            Load();
        }

        else
        {
           
            Load();
        }
      

    }


    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {

        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    
}
