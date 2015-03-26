﻿using System;
using System.Collections.Generic;
using System.Text;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

namespace AutoDrawDWG
{
    public class ProjetStarter
    {
        public static bool _IsShow = false;
        //private MainForm form;
        Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

        
        [CommandMethod("AutoDrawer")]
        public void starter()
        {
            using (Form1 form = new Form1())
            {
                Application.ShowModelessDialog(form);  //显示非模态对话框 
            }
            /*
            if (form == null)
            {
                form = new Form1();
                Application.ShowModelessDialog(form);  //显示非模态对话框 
            }
            else if (form.Visible == false && form.IsDisposed == false)
            {
                form.Visible = true;
            }
            else if (form.IsDisposed == true)
            {
                form = new Form1();
                Application.ShowModelessDialog(form);  //显示非模态对话框 
            }
            else
            {
                ed.WriteMessage("界面已打开,请勿重复打开..");
            }*/
        }
    }
}
