using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBtnController : MonoBehaviour
{

    public void OnStartBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

}
