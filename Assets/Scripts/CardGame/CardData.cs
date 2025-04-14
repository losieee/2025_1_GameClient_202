using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[CreateAssetMenu(fileName = "NewCard" , menuName = "Cards/Card Data")]

public class CardData : ScriptableObject
{
    public enum CardType
    {
        Attack,          //����ī��
        Heal,            //ȸ��ī��
        Buff,            //����ī��
        Utility          //��ƿ��Ƽ ī��
    }

    public string cardName;    //ī�� �̸�
    public string description;  //ī�� ����
    public Sprite artwork;    //ī�� �̹���
    public int manaCost;      //���� ���
    public int effectAmount;    //���ݷ�/ȿ�� ��
    public CardType cardType;      //ī�� Ÿ��

    public Color GetCardColor()
    {
        switch (cardType)
        {
            case CardType.Attack:
                return new Color(0.9f, 0.3f, 0.3f);      //����
            case CardType.Heal:
                return new Color(0.3f, 0.9f, 0.3f);      //���
            case CardType.Buff:
                return new Color(0.3f, 0.3f, 0.9f);      //�Ķ�
            case CardType.Utility:
                return new Color(0.9f, 0.9f, 0.3f);      //���
            default:
                return Color.white;
        }
    }
    
}
