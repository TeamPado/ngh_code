using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public TeamSlot[] slots; // ���� 4�� ����
    public Sprite[] availableCharacters; // ����� ���� ������ �̹���

    public void AddRandomCharacterToTeam()
    {
        foreach (TeamSlot slot in slots)
        {
            if (!slot.isOccupied)
            {
                // ���÷� ���� ���� ��ġ
                int index = Random.Range(0, availableCharacters.Length);
                slot.SetCharacter(availableCharacters[index]);
                break;
            }
        }
    }
}
