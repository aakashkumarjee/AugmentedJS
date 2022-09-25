using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ScenePog : MonoBehaviour
{
    public GameObject VirtualButton;
    public GameObject Scenename;

    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(true);
        SceneManager.LoadScene("Pg Scene 3");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(false);
    }



}
