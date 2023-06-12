using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   void Awake() {
      DontDestroyOnLoad(GameObject.Find("Sound Manager"));
   }

   public void StartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      FindObjectOfType<SoundManager>().PlayMusicTrack("Level1");
   }
}
