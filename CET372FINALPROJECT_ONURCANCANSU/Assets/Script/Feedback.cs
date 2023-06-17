using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback : MonoBehaviour
{
    [SerializeField] Dropdown q1;
    [SerializeField] Dropdown q2;
    [SerializeField] Dropdown q3;
    [SerializeField] Dropdown q4;
    [SerializeField] Dropdown q1_1;
    [SerializeField] Dropdown q2_1;
    [SerializeField] Dropdown q3_1;
    [SerializeField] Dropdown q4_1;
    [SerializeField] Image q1Feedback;
    [SerializeField] Image q2Feedback;
    [SerializeField] Image q3Feedback;
    [SerializeField] Image q4Feedback;
    [SerializeField] Image q1_1Feedback;
    [SerializeField] Image q2_1Feedback;
    [SerializeField] Image q3_1Feedback;
    [SerializeField] Image q4_1Feedback;
    //[SerializeField] Activity3Controller controller;
    [SerializeField] Sprite correct;
    [SerializeField] Sprite wrong;

    public int correctCount = 0;
    private int[] answers =
    {
        1,
        2,
        2,
        1,
        2,
        1,
        1,
        2,
    };
    public int questionCount = 8;

    private Image[] feedbacks = new Image[8];
    void Start()
    {
        q1.onValueChanged.AddListener(delegate { checkV2(q1, 1); });
        q2.onValueChanged.AddListener(delegate { checkV2(q2, 2); });
        q3.onValueChanged.AddListener(delegate { checkV2(q3, 3); });
        q4.onValueChanged.AddListener(delegate { checkV2(q4, 4); });
        q1_1.onValueChanged.AddListener(delegate { checkV2(q1_1, 5); });
        q2_1.onValueChanged.AddListener(delegate { checkV2(q2_1, 6); });
        q3_1.onValueChanged.AddListener(delegate { checkV2(q3_1, 7); });
        q4_1.onValueChanged.AddListener(delegate { checkV2(q4_1, 8); });

        SetInteractable(1, false);
        SetInteractable(2, false);
        SetInteractable(3, false);
        SetInteractable(4, false);

        feedbacks.SetValue(q1Feedback, 0);
        feedbacks.SetValue(q2Feedback, 1);
        feedbacks.SetValue(q3Feedback, 2);
        feedbacks.SetValue(q4Feedback, 3);
        feedbacks.SetValue(q1_1Feedback, 4);
        feedbacks.SetValue(q2_1Feedback, 5);
        feedbacks.SetValue(q3_1Feedback, 6);
        feedbacks.SetValue(q4_1Feedback, 7);
    }

    public void SetInteractable(int no, bool value)
    {
        switch (no)
        {
            case 1:
                q1.interactable = value;
                q1_1.interactable = value;
                break;
            case 2:
                q2.interactable = value;
                q2_1.interactable = value;
                break;
            case 3:
                q3.interactable = value;
                q3_1.interactable = value;
                break;
            case 4:
                q4.interactable = value;
                q4_1.interactable = value;
                break;
            default:
                return;
        }
    }

    void checkV2(Dropdown q, int qNo)
    {
        if (q.value == 0)
        {
            return;
        }


        Image fb = feedbacks[qNo - 1];

        int answer = answers[qNo - 1];

        Debug.Log($"qNo: {qNo}. answer: {answer}.");

        if (q.value == answers[qNo - 1])
        {
            q.interactable = false;
            fb.sprite = correct;
            correctCount++;
            if (correctCount == questionCount)
            {
                //controller.Win();
            }
        }
        else
        {
            fb.sprite = wrong;
        }
        fb.gameObject.SetActive(true);
    }
}
