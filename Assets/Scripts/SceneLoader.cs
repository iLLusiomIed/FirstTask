using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public SceneEnum SceneName;
   public void LoadScene()
   {
        SceneManager.LoadScene(SceneName.ToString());
   }
}
public enum SceneEnum
{
    FirstScene,
    SecondScene
}