using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWork {
    public class UIPlane:MonoBehaviour{
		
        public virtual void OnEnable() {
            //UI视图显示时逻辑
        }

        public virtual void Begin() {
            //UI视图开始时逻辑
        }

        public virtual void Pause() {
            //UI视图暂停逻辑
        }

        public virtual void OnDisable() {
            //UI视图隐藏后逻辑
        }
    }
}


