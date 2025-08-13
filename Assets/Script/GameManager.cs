using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    [SerializeField] private GameObject[] playBtn;

    
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null) { Destroy(this); }
        instance = this;
    }

    public void StartGame()
    {
        if (!gameStarted)
        {
            StartSpawning();

            gameStarted = true;
            foreach(GameObject g in playBtn) {
            g.SetActive(false);
            }
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);

    }

    private void SpawnBlock()
    {
        Vector3 spawnPos=spawnPoint.position;

        spawnPos.x=Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity);
    }
}
