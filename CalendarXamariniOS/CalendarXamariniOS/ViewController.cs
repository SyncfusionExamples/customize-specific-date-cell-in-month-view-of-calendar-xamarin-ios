using CoreGraphics;
using Foundation;
using Syncfusion.SfCalendar.iOS;
using System;
using UIKit;

namespace CalendarXamariniOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        SFCalendar calendar;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //// Initialize SfCalendar
            calendar = new SFCalendar();
            calendar.ViewMode = SFCalendarViewMode.SFCalendarViewModeMonth;

            calendar.DrawMonthCell += CalendarDrawMonthCell;
            this.View.AddSubview(calendar);
        }

        private void CalendarDrawMonthCell(object sender, DrawMonthCellEventArgs e)
        {
            NSCalendar date = NSCalendar.CurrentCalendar;
            NSDate today = new NSDate();

            NSDateComponents monthCellDateComponents = date.Components(
                    NSCalendarUnit.Year | NSCalendarUnit.Month | NSCalendarUnit.Day, e.MonthCell.Date);
            NSDateComponents todayDateComponents = date.Components(
                  NSCalendarUnit.Year | NSCalendarUnit.Month | NSCalendarUnit.Day, today);

            UIButton button = new UIButton();
            button.SetTitle(monthCellDateComponents.Day.ToString(), UIControlState.Normal);
            button.SetTitleColor(UIColor.Black, UIControlState.Normal);

            if (e.MonthCell.IsCurrentMonth)
            {
                if (monthCellDateComponents.Day == todayDateComponents.Day && monthCellDateComponents.Month == todayDateComponents.Month && monthCellDateComponents.Year == todayDateComponents.Year)
                {
                    //// customized paricular date by setting differernt background color
                    button.BackgroundColor = UIColor.Red;
                }
                else
                {
                    button.BackgroundColor = UIColor.LightGray;
                }

                e.MonthCell.View = button;
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}