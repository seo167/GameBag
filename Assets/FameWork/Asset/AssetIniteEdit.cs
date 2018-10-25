using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FrameWork{
	//主要用来对对象进行初始化
	public class AssetIniteEdit : MonoBehaviour {
		static AssetIniteEdit _AssetIniteEdit;

		public static AssetIniteEdit Instace{
			get{ 
				if(_AssetIniteEdit==null){
					GameObject obj = new GameObject ();
					obj.name="[AssetIniteEdit]";

					_AssetIniteEdit=obj.AddComponent<AssetIniteEdit> ();
				}
				return _AssetIniteEdit;
			}
		}

		public UnityEvent _Action;

		[SerializeField]List<AssetInite> AssetIniteList;

		public int AssetIniteListCount{
			get{
				if(AssetIniteList==null){
					return 0;
				}
				return AssetIniteList.Count;
			}
		}

		void Awake(){
			_AssetIniteEdit = this;
			ResClac.AddResNum ((ushort)AssetIniteList.Count);
		}

		public void AddAssetInite(AssetInite temp){

			if(AssetIniteList==null){
				AssetIniteList = new List<AssetInite> ();
			}


			if (AssetIniteList.Count > 0) {
				if (AssetIniteList.Contains (temp)) {
					return;
				}
			}
			AssetIniteList.Add (temp);

		}

		public void IniteTheObj(){
			StartCoroutine ("_IniteTheObj");
		}


		IEnumerator _IniteTheObj(){
			int num = AssetIniteList.Count;
			for(int i=0;i<num;++i){
				AssetIniteList [0].Inite ();
			}

			while(AssetIniteList.Count>0){
				ClearListForTime ();
				yield return null;
			}
			ResClac.SetZeroFResNum ();
			yield return new WaitForSeconds (0.5f);

			if(_Action!=null){
				_Action.Invoke ();
			}
		}

		public void Remove(AssetInite _t){
			if(!AssetIniteList.Contains(_t)){
				return;
			}

			AssetIniteList.Remove(_t);

			Debug.Log ("AssetIniteList:"+AssetIniteList.Count);
		}

		float nowTime=0.0f;//当前时间
		float prevTime=0.0f;

		void ClearListForTime(){
			nowTime = Time.deltaTime;

			if((nowTime-prevTime)>=prevTime){
				for(int i=0;i<AssetIniteList.Count;++i){
					if(AssetIniteList[i]==null){
						AssetIniteList.Remove(null);
					}
				}

				prevTime = 0.0f;
				prevTime = 0.0f;
				return;
			}
			prevTime += nowTime;
		}

	}
}


