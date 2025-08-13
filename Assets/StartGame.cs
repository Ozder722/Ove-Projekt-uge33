using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartTheGame()
    {
        GameManager.instance.StartGame();
    }
}
