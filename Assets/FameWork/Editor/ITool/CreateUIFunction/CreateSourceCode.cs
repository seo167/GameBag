﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class CreateSourceCode{

    enum Type {
        CONTROLLER,
        MODEL,
        PLANE
    }

    //创建代码文件
    public static void CreateUISourceCode(string FloderStr,string SourceName) {
        CreateSource(Type.CONTROLLER, FloderStr,SourceName);
        //CreateSource(Type.MODEL, FloderStr, SourceName);
        //CreateSource(Type.PLANE, FloderStr, SourceName);
        Debug.Log(Application.dataPath + FloderStr);
    }

    static void CreateSource(Type t, string FloderStr, string SourceName) {
        StreamWriter sw=null;
        switch (t) {
            case Type.CONTROLLER:
                sw = new StreamWriter(Application.dataPath + FloderStr + "/" + SourceName + "Controller.cs");
                WriteHead(sw);
                WriteController(sw, SourceName);
                break;
            case Type.MODEL:
                //sw = new StreamWriter(Application.dataPath + FloderStr + "/" + SourceName + "Model.cs");
                break;
            case Type.PLANE:
               // sw = new StreamWriter(Application.dataPath + FloderStr + "/" + SourceName + "Plane.cs");
                break;
        }
        sw.Write("\n}");
        sw.Flush();
        sw.Close();
    }

    static void WriteHead(StreamWriter _sw) {
        _sw.Write("using System.Collections;\nusing System.Collections.Generic;\nusing UnityEngine;\n\n\nnamespace FrameWork {");
       
    }

    static void WriteController(StreamWriter _sw, string SourceName) {
        _sw.Write("\n  public class " + SourceName + "Controller:UIController{");
        _sw.Write("\n    public "+SourceName+ "Controller(UIPlane _uIPlane,UIModel _uIModel):base(_uIPlane,_uIModel) {}");
        _sw.Write("\n     public override void ShowUI() {}");
        _sw.Write("\n     public override void UILogic() {}");
        _sw.Write("\n  }");
    }

}
