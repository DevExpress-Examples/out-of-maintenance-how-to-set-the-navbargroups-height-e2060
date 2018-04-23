using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace CustomView {
    
    public class MyViewInfoRegistrator : DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator
    {
        public override string ViewName { get { return "MyView"; } }
        
        int groupHeight = 0;
        public int GroupHeight
        {
            get { return groupHeight; }
            set { groupHeight = value; }
        }
        public override BaseNavGroupPainter CreateGroupPainter(NavBarControl navBar)
        {
            return new MyViewNavBarGroupPainter(navBar);
        }
    }

    public class MyViewNavBarGroupPainter : DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneGroupPainter
    {
        public MyViewNavBarGroupPainter(NavBarControl navBar) : base(navBar) { }

        public override Rectangle CalcObjectMinBounds(ObjectInfoArgs e)
        {
            Rectangle rect = base.CalcObjectMinBounds(e);
            MyViewInfoRegistrator view = NavBar.View as MyViewInfoRegistrator;
            rect.Height = view.GroupHeight;
            return rect;
        }
    }
}
