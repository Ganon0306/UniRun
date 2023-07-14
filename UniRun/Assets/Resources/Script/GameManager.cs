using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{public static GameManager instance;

    public bool isGameOver = false;
    public TMP_Text scoreText;        //Text mesh pro ������Ʈ �� ���
    // public Text scoreText;              //Legacy Text ������Ʈ �� ���
    public GameObject gameoverUi;
    GameObject player;
    private int score = 0;
    private int time = 0;

    public float qjtjt;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }        
        else
        {
            Debug.LogWarning("���� �� �� �̻����� ���� �Ŵ����� �����մϴ�.");
            Destroy(gameObject);
        }

    }
    //! ������Ʈ�� �����ϴ��� ���θ� üũ�ϴ� �Լ�
    //public static void IsValid<T>(This T target) where T : Component
    //{
    //    if(TargetJoint2D == null || target == default) { return false; }
    //    else { return true; }
    //}
    // Start is called before the first frame update
    
    
    //! ����Ʈ�� ��ȿ���� ���θ� üũ�ϴ� �Լ�
    //public static void IsValid<T>(This List<T> target) where T : Component
    //{
    //    bool inInvalid = (target == null || target == default);
    //    isInvalid = isInvalid || target.Count == 0;

    //    if(isInvalid == true) { return false; }
    //    else { return true; }
    //}
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if((qjtjt + 3f) <= Time.time && qjtjt != 0f) 
        {
            qjtjt = 0f;
            player.transform.localScale /= 1.5f;
        }
    }

    public void AddScore(int newScore)
    {
        
        if (isGameOver == false)
        {
            score += newScore;
            scoreText.text = string.Format("Score : {0}", score);
            Debug.Log(score);
        }
    }
    public void OnPlayerDead()
    {
        isGameOver = true;
        gameoverUi.SetActive(true);
    }

    public void LinkPlayer(GameObject player_)
    {
        player = player_;
    }
}
