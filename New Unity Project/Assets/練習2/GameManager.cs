using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoldierA = new Soldier();
    public warrior warriorA = new warrior();
    void Start()
    {
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值-取得" + SoldierA.Getexp());

        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值-設定" + SoldierA.exp);

        warriorA.lv = 50;
        Debug.Log("戰士經驗值-取得:" + warriorA.Exp);

        warriorA.Exp = 777;
        Debug.Log("戰士經驗值-設定:" + warriorA.Exp);
    }

    
}
