using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace FrameWork{

	//资源初始化
	public class AssetInite : MonoBehaviour {

		[SerializeField]protected string AssetPathName;

		[SerializeField]protected string AssetBundlePathName;

		public string GetAssetBundlePathName{
			get{
				return AssetBundlePathName;
			}
		}

		[SerializeField]UnityEvent _Action;

		public UnityEvent Action{
			get{
				return _Action;
			}
		}

		enum AssetType{
			ASSETSTREAMING,
			ASSETBUNDLE
		}

		[SerializeField]AssetType _AssetType;
		protected Texture2D _tex;
		public void Inite(){
			if (_AssetType == AssetType.ASSETBUNDLE) {
				SetObj ();
			} else {
				ResourseAssetManager.Instace.LoadStreamingAsset (AssetPathName,SetPicture);
				AssetIniteEdit.Instace.Remove (this);
			}

			if(_Action!=null){
				_Action.Invoke ();
			}

		}

		public void SetAsset(string mName){
			AssetPathName = mName;
			_AssetType = AssetType.ASSETSTREAMING;
		}

		public void SetAssetBundleName(string mName){
			AssetBundlePathName = mName;
			_AssetType = AssetType.ASSETBUNDLE;
		}

		protected virtual void SetPicture(Texture _picture){
			ResClac.MinUsResNum ();
			if(_picture!=null){
				if(GetComponent<Image>()!=null){
					GetComponent<Image> ().sprite = Sprite.Create ((Texture2D)_picture,new Rect(0,0,_picture.width,_picture.height),new Vector2(0.5f,0.5f));
					AssetIniteEdit.Instace.Remove (this);
					return;
				}

				if(GetComponent<SpriteRenderer>()!=null){
					GetComponent<SpriteRenderer> ().sprite = Sprite.Create ((Texture2D)_picture,new Rect(0,0,_picture.width,_picture.height),new Vector2(0.5f,0.5f));
					AssetIniteEdit.Instace.Remove (this);
					return;
				}
			}
		}

		protected virtual void SetObj(){
			_tex = (Texture2D)ResourseAssetManager.Instace.GetDictionary (AssetBundlePathName.ToLower());
			ResClac.MinUsResNum ();
			if(_tex==null){
				Debug.Log ("空的,"+AssetBundlePathName.ToLower());
				AssetIniteEdit.Instace.Remove (this);
				return;
			}
			if(this.GetComponent<Image>()!=null){
				GetComponent<Image> ().sprite = Sprite.Create (_tex,new Rect(0,0,_tex.width,_tex.height),new Vector2(0.5f,0.5f));
			}else if(GetComponent<SpriteRenderer>()!=null){
				GetComponent<SpriteRenderer>().sprite=Sprite.Create (_tex,new Rect(0,0,_tex.width,_tex.height),new Vector2(0.5f,0.5f));
			}
			AssetIniteEdit.Instace.Remove (this);

		}

		protected virtual void OnDestroy(){
			_tex = null;
		}

	}
}


