using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransisiScene : MonoBehaviour
{
    public void PindahKeSceneMenu()
    {
        SceneManager.LoadScene("1.Menu");
    }

    public void PindahKeSceneMateri1()
    {
        SceneManager.LoadScene("2.MateriPertama");
    }

    public void PindahKeSceneMateri2()
    {
        SceneManager.LoadScene("3.MateriKedua");
    }

    public void PindahKeSceneGame()
    {
        SceneManager.LoadScene("4.Game");
    }

    public void KeluarGame()
    {
        Application.Quit();
    }
}
