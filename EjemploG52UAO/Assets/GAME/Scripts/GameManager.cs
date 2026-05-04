using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int totalScore=0;
    private int objSelect = 0;

    public int TotalScore { get => totalScore; set => totalScore = value; }
    public int ObjSelect { get => objSelect; set => objSelect = value; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        TotalScore += score;
    }

    public void AddObject(int obj) 
    {
        ObjSelect += obj;
    }

}
