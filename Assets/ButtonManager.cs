using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void goToGame() // button을 위한 함수는 항상 public이어야 한다. (외부에서 호출하기 위해서 그런듯)
    {
        SceneManager.LoadScene("GameScene");
    }

    public void goToSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
