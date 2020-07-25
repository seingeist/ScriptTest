using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
	private int hp = 100;   // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;    // 魔力

	// 攻撃用の関数
	public void Attack()
	{
		Debug.Log(this.power + "のダメージを与えた");
	}

	// 魔法用の関数
	public void Magic()
    {
		if (mp > 4)
		{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
			Debug.Log("MPが足りないため魔法が使えない。");
		}
    }

	// 防御用の関数
	public void Defence(int damage)
	{
		Debug.Log(damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}

}
public class Test : MonoBehaviour {
	void Start()
	{
		int[] array = { 1, 2, 3, 4, 5 };
		for (int i = 0; i < 5; i++)
		{
			Debug.Log(array[i]);
		}
		for (int i = 4; i > -1; i--)
		{
			Debug.Log(array[i]);
		}

		Boss lastboss = new Boss();
		for(int i = 0; i < 11; i++)
        {
			Debug.Log("今は" + (i + 1) + "回目の攻撃");
			lastboss.Magic();
		}
	}
		void Update () {
		
	}
}
