using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public AudioSource clickButton;

    public void AudioPlay()
    {
        clickButton.Play();
    }
     
    public void NextScene(int i)
    {
        SceneManager.LoadScene(i);
    }


}
