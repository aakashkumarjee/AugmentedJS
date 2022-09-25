using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SceneLoader : MonoBehaviour
{
    public GameObject VirtualButton;

    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(true);
        SceneManager.LoadScene("Pg Scene 2");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(false);
    }



}
