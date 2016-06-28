using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Unit : MonoBehaviour {

	/// <summary>
	/// 上面一格
	/// </summary>
	public Unit MyU {
		get
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 下面一格
	/// </summary>
	public Unit MyD
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 左边一格
	/// </summary>
	public Unit MyL
	{
		get
		{
			throw new NotImplementedException();
		}
	}


	/// <summary>
	/// 右边一格
	/// </summary>
	public Unit MyR
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 站在上面的玩家卡
	/// </summary>
	public Character StandOn {
		get {
			throw new NotImplementedException();
		}
		set {
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 对一个格子造成伤害
	/// </summary>
	/// <param name="DP">伤害点数</param>
	public void Attack(int DP) {
		//TODO: 传递参数
		throw new NotImplementedException();
	}

	/// <summary>
	/// 把本格的玩家卡移走
	/// </summary>
	/// <param name="target">目标格</param>
	public void Move(Unit target) {
		//TODO: 确认可移动并且转移，删除本格对之引用，消耗玩家卡的MP
		throw new NotImplementedException();
	}

}
