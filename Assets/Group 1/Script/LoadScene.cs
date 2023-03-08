using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Leung Cheuk Sing2");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Mak Fu Yin");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Tse Kwok Pan");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Cheuk Long Sing");
    }
}
