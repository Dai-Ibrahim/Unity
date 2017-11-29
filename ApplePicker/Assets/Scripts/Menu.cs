using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Canvas MainCanvas;
    public Canvas DifficultyCanvas;
    void Awake()
    {
        DifficultyCanvas.enabled = false;
    }
    public void DifficultyOn()
    {
        DifficultyCanvas.enabled = true;
        MainCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        DifficultyCanvas.enabled = false;
        MainCanvas.enabled = true;
    }
    public void ChangeScene(int index)
    {
        Application.LoadLevel(index);

    }
}

