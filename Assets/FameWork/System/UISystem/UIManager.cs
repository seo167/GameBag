using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWork {
    public class UIManager{
        private static UIManager mUIManager;

        public static UIManager Instace{
            get {
                if (mUIManager == null) {
                    mUIManager = new UIManager();
                }

                return mUIManager;
            }
        }

        Dictionary<string, UIController> ControllerDictionary;

        private UIManager() {
            ControllerDictionary = new Dictionary<string, UIController>();
        }

        //注册UIController
        public void RegisterController(string _name,UIController _uiController) {
            if (!ControllerDictionary.ContainsKey("Controller_"+_name)) {
                ControllerDictionary.Add("Controller_" + _name,_uiController);
            }
        }

        //注销UIController
        public void UnRegister(string _name) {
            if (ControllerDictionary.ContainsKey("Controller_" + _name)){
                ControllerDictionary.Remove("Controller_" + _name);
            }
        }

        //限定类型获得UIController
        public T GetController<T>(string _name) where T : UIController {
            if (ControllerDictionary.ContainsKey("Controller_" + _name)) {
                return ControllerDictionary["Controller_" + _name] as T;
            }
            return null;
        }
    }
}