using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void funcPoint(Combination temp);

public class CombinationClass : MonoBehaviour
{
    static CombinationClass _combination;

    public static CombinationClass Inter() {
        return _combination;
    }

	[System.Serializable]
	public class CombinationSettings{
		public Combination Combination1=Combination.Default;
		public Combination Combination2=Combination.Default;
		public Combination Combination3=Combination.Default;
		public Combination Combination4=Combination.Default;
		public Combination Combination5=Combination.Default;
		public Combination Combination6=Combination.Default;
		public Combination Combination7=Combination.Default;
		public Combination Combination8=Combination.Default;
		public Combination Combination9=Combination.Default;
		public Combination Combination10=Combination.Default;
	}


	[Header("组合设置")]
	[SerializeField]CombinationSettings[] _combinationSetting;


	void Awake(){
		_combination = this;
	}

    //组合计算
    public int TheCombination(ushort Combination1,ushort Combination2) {
        return (Combination1 ^ Combination2);
    }

    public int TheCombination(ushort Combination1, ushort Combination2,ushort Combination3){
		return (Combination1 ^ Combination2 ^Combination3);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3,ushort Combination4){
		return (Combination1 ^ Combination2 ^ Combination3 ^Combination4);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4, 
        ushort Combination5){
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4, 
        ushort Combination5, ushort Combination6){
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5 ^ Combination6);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4,
       ushort Combination5, ushort Combination6,ushort Combination7){
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5 ^ Combination6 ^ Combination7);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4,
     ushort Combination5, ushort Combination6, ushort Combination7, ushort Combination8){
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5 ^ Combination6 ^ Combination7 ^ Combination8);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4,
    ushort Combination5, ushort Combination6, ushort Combination7, ushort Combination8,ushort Combination9){
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5 ^ Combination6 ^ Combination7 ^ Combination8 ^ Combination9);
    }

    public int TheCombination(ushort Combination1, ushort Combination2, ushort Combination3, ushort Combination4,
   ushort Combination5, ushort Combination6, ushort Combination7, ushort Combination8, ushort Combination9,
   ushort Combination10) {
        return (Combination1 ^ Combination2 ^ Combination3 ^ Combination4 ^ Combination5 ^ Combination6 ^ Combination7 ^ Combination8 ^ Combination9 ^ Combination10);
    }

	public int GetCombination(int num){
		return TheCombination ((ushort)_combinationSetting[num].Combination1,(ushort)_combinationSetting[num].Combination2,(ushort)_combinationSetting[num].Combination3,
			(ushort)_combinationSetting[num].Combination4,(ushort)_combinationSetting[num].Combination5,(ushort)_combinationSetting[num].Combination6,(ushort)_combinationSetting[num].Combination7,
			(ushort)_combinationSetting[num].Combination8,(ushort)_combinationSetting[num].Combination9,(ushort)_combinationSetting[num].Combination10);
	}


	public int CombinationCount{
		get{ return _combinationSetting.Length;}
	}

	//组合执行动作
	public void Action(CombinationSettings _CombinationSettings,funcPoint func){
		if(_CombinationSettings.Combination1!=Combination.Default){
			func (_CombinationSettings.Combination1);
		}

		if(_CombinationSettings.Combination2!=Combination.Default){
			func (_CombinationSettings.Combination2);
		}

		if(_CombinationSettings.Combination3!=Combination.Default){
			func (_CombinationSettings.Combination3);
		}

		if(_CombinationSettings.Combination4!=Combination.Default){
			func (_CombinationSettings.Combination4);
		}

		if(_CombinationSettings.Combination5!=Combination.Default){
			func (_CombinationSettings.Combination5);
		}

		if(_CombinationSettings.Combination6!=Combination.Default){
			func (_CombinationSettings.Combination6);
		}

		if(_CombinationSettings.Combination7!=Combination.Default){
			func (_CombinationSettings.Combination7);
		}

		if(_CombinationSettings.Combination8!=Combination.Default){
			func (_CombinationSettings.Combination8);
		}

		if(_CombinationSettings.Combination9!=Combination.Default){
			func (_CombinationSettings.Combination9);
		}

		if(_CombinationSettings.Combination10!=Combination.Default){
			func (_CombinationSettings.Combination10);
		}

	}

	public CombinationSettings GetCombinationSettings(int num){
		return _combinationSetting [num];
	}
}

