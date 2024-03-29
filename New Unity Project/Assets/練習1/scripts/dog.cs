﻿using UnityEngine;
[System.Serializable]
public class dog
{
    #region 欄位;
    public string name;
    public float weight;
    public string type;
    private string sex;
    public string color;
    public int age;
    #endregion

    public dog(string sex,int age)
    {
        this.sex = sex;
        this.age = age;
    }

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
    public int ConverAge()
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