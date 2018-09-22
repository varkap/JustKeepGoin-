using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    string SceneName;
    void OnClick()
    {
        SceneManager.LoadScene("TrainingLevel", LoadSceneMode.Additive);
    }
}