using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Side {
	LEFT,
	RIGHT
}

public class HCLGame : MonoBehaviour
{

	/// <summary>
	/// 棋盘，无序
	/// </summary>
	public List<Unit> Grid;


	/// <summary>
	/// 宣告一方胜利
	/// </summary>
	/// <param name="winner">一方</param>
	public void Win(Side winner) {
		//TODO: 加特技
	}

	/// <summary>
	/// 表示回合数目：开局时是0
	/// </summary>
	int Round = 0;

	/// <summary>
	/// 初始化
	/// </summary>
	void Start() {
		//TODO：绑定棋盘，设定卡片
	}
}
