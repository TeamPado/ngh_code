using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public int str = 0;
    public int availablePoints = 5;

    public Text strText;
    public Text pointText;
    void Start()
    {
        UpdateUI(); // ������ �� �� UI ������Ʈ
    }
    public void AddSTR()
    {
        if (availablePoints > 0)
        {
            str++;
            availablePoints--;
            UpdateUI();
        }
    }

    public void UpdateUI()
    {
        if (strText != null)
            strText.text = str.ToString();

        if (pointText != null)
            pointText.text = " " + availablePoints;
    }
}