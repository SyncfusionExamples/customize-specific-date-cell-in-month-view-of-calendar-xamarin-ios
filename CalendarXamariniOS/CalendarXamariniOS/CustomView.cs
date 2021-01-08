using System;
using CoreGraphics;
using UIKit;

namespace CalendarXamariniOS
{
    public class CustomView : UIView
    {
        public CustomView() : base()
        {
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            this.Subviews[0].Frame = new CGRect(0, 20, this.Frame.Right, 50);
        }
    }
}
