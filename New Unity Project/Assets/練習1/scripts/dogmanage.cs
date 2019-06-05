using UnityEngine;
public class dogmanage : MonoBehaviour
{
    #region 欄位
    public dog dogA = new dog("公",8);
    public dog dogB = new dog("母",7);
    #endregion

    #region 事件
    private void Start()
    {
        dogA.name = "小柴";
        dogA.weight = 20.5f;
        dogA.type = "秋田犬";
        //dogA.sex = "公";
        dogA.color = "黃色";
        //dogA.age = 8;

        dogB.name = "小白";
        dogB.weight = 15.5f;
        dogB.type = "拉不拉多犬";
       // dogB.sex = "母";
        dogB.color = "白色";
       // dogB.age = 7;

        Debug.Log(dogA.name + "品種" + dogA.type + "顏色:" + dogA.color);
        Debug.Log(dogB.name + "品種" + dogB.type + "顏色:" + dogB.color);

        dogA.Bark();
        dogB.Bark();

        Debug.Log(dogA.name + "的實際年齡是" + dogA.ConverAge());
        Debug.Log(dogB.name + "的實際年齡是" + dogB.ConverAge());

        dogA.Eat("狗食");
        dogB.Eat("狗食", 10);
    }

    #endregion
}