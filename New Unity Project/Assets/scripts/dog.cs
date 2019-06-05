using UnityEngine;

public class dog
{
    #region 欄位;
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法;
    /// <summary>
    /// 狗狗亂叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + "旺旺!!");
    }
    /// <summary>
    /// 轉換年齡的方法
    /// </summary>
    public void ConverAge()
    {
        return age * 7;
    }
    /// <summary>
    /// 狗狗吃東西的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="speed"></param>
    public void Eat(string food,string speed = "慢")
    {
        Debug.Log(name + ":" + food + "，速度" + speed);
    }
    /// <summary>
    /// 狗狗吃東西的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="count"></param>
    public void Eat(string food,int count)
    {
        Debug.Log(name + ":" + food + "，份量:" + count);
    }
    #endregion


    #region
    #endregion
}