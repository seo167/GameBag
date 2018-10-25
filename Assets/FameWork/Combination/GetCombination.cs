using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCombination : MonoBehaviour {
	[SerializeField]protected Combination _combination;

	public Combination GetTheCombination{
		get{ return _combination;}
	}

}
