using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonClick : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(0);
    }
}
