using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Password : MonoBehaviour
{
    public InputField password;
    public string levelOne;
    public string levelTwoOne;
    public string levelTwoTwo;
    public string levelThreeOne;
    public string levelThreeTwo;
    public string levelFourOne;
    public string levelFourTwo;
    public string levelFiveOne;
    public string levelFiveTwo;



    public void passwordcheck()
    {
        if (password.text.ToString() == levelOne)
        {
            SceneManager.LoadScene("Level One");
        }
        if (password.text.ToString() == levelTwoOne)
        {
            SceneManager.LoadScene("Level 2 1");
        }
        if (password.text.ToString() == levelTwoTwo)
        {
            SceneManager.LoadScene("Level 2 2");
        }
        if (password.text.ToString() == levelThreeOne)
        {
            SceneManager.LoadScene("Level 3 1");
        }
        if (password.text.ToString() == levelThreeTwo)
        {
            SceneManager.LoadScene("Level 3 2");
        }
        if (password.text.ToString() == levelFourOne)
        {
            SceneManager.LoadScene("Level 4 1");
        }
        if (password.text.ToString() == levelFourTwo)
        {
            SceneManager.LoadScene("Level 4 2");
        }
        if (password.text.ToString() == levelFiveOne)
        {
            SceneManager.LoadScene("Level 5 1");
        }
        if (password.text.ToString() == levelFiveTwo)
        {
            SceneManager.LoadScene("Level 5 2");
        }

    }
}
