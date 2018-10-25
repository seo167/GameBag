using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWork {
    public class UIController{
        UIPlane mUIPlane;
        UIModel mUIModel;

        public UIController(UIPlane _uIPlane,UIModel _uIModel) {
            mUIPlane = _uIPlane;
            mUIModel = _uIModel;
        }

        //向UIManager註冊控制器
        void Register(string _name) {
            UIManager.Instace.RegisterController("Controller_" + _name, this);
        }

        #region 顯示UI
        public virtual void ShowUI() {
            //.....
        }
        #endregion

        #region 執行UI邏輯
        public virtual void UILogic() {
            //.......
        }
        #endregion
        
    }
}


