using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using System.Diagnostics;

namespace devx
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            #region 포문 연습
            //string result = "Hello, Revit!";
            //int count = 0;
            //double sum = 0.0;
            //bool isActive = true;
            //List<string> list = new List<string>();
            //list.Add("대한");
            //list.Add("민국");
            //list.Add("만세");
            //0~10까시 숫자중에서 홀수만 출력
            //for (int i = 1; i < 10; i+=2)
            //{
            //    Debug.Print(i.ToString());
            //}
            //List<string> list1 = new List<string>();
            //list1.Add("대한AA");
            //list1.Add("민국BB");
            //list1.Add("만세CC");
            //foreach (string a in list)
            //{
            //    foreach (string item in list1)
            //    {
            //        Debug.Print(a + "@" + item); 
            //    }
            //}
            #endregion

            List<XYZ> points = new List<XYZ>();

            XYZ sp = new XYZ(0, 0, 0);
            XYZ ep = new XYZ(5000, 0, 0)/304.8;
            XYZ sp1 = new XYZ(5000, 5000, 0)/304.8;
            XYZ sp2 = new XYZ(0, 5000, 0) / 304.8;
            points.Add(sp);
            points.Add(ep);
            points.Add(sp1);
            points.Add(sp2);

            List<Line> lines = new List<Line>();
            for(int i = 0; i < points.Count; i++)
            {

            }

            int count = -1;
            foreach (XYZ item in points)
            {
                count++;
                if(count < points.Count - 1)
                {
                    Line line = Line.CreateBound(item, points[count + 1]);
                    lines.Add(line);
                }
                else if(count == points.Count - 1)
                {
                    Line line = Line.CreateBound(item, points[0]);
                    lines.Add(line);
                }
            }


            return Result.Succeeded;
        }
    }
}
