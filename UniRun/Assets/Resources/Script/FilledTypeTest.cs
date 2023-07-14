using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FilledTypeTest : MonoBehaviour
{
    public Image filledTypeImg;

    private void Awake()
    {
        filledTypeImg.fillAmount = 1.0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PassedCoolTime(0.25f));
    }

    // Update is called once per frame
    void Update()
    {
    }
    //private void FoxedUpdate()
    //{
        //if (0 < filledTypeImg.fillAmount)
        //{

        //    filledTypeImg.fillAmount -= (Time.deltaTime * 0.5f);
        //}
    //}
    private IEnumerator PassedCoolTime(float cooltimeDelay)
    {
        float cooltimePercent = 0.1f;
        while (0 < filledTypeImg.fillAmount)
        {
            // �̸�ŭ �ð��� �ɸ���.
            yield return new WaitForSeconds(cooltimeDelay);

            // �ð��� ������ ������ ó���Ѵ�.
            filledTypeImg.fillAmount -= cooltimePercent;
        }
    }
}
