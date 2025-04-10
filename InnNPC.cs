using UnityEngine;

public class InnNPC : MonoBehaviour
{
    public GameObject overlayUI; // �� ���� �� ���� ��������
    public GameObject eIcon;     // E ������

    private bool isPlayerNearby = false;
    private StatManager statManager;

    void Start()
    {
        eIcon.SetActive(false); // �⺻������ ����
        overlayUI.SetActive(false); // ó���� ���α�

        // StatManager ����
        statManager = overlayUI.GetComponent<StatManager>();
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            ToggleOverlay();
        }

        if (overlayUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            overlayUI.SetActive(false);
            Debug.Log("���â ���� (ESC)");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            eIcon.SetActive(true); // E ������ ǥ��
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            eIcon.SetActive(false); // E ������ ����

            if (overlayUI.activeSelf)
            {
                overlayUI.SetActive(false); // UI �������� ���� ����
                Debug.Log("�־����� ���â ����");
            }
        }
    }

    private void ToggleOverlay()
    {
        bool nextState = !overlayUI.activeSelf;
        overlayUI.SetActive(nextState);

        if (nextState && statManager != null)
        {
            statManager.UpdateUI(); // UI ���� �� �ֽ� ������ ����
            Debug.Log("���â ����");
        }
    }
}
