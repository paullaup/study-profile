using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class MakeScheduleReleaseControl
    {

        private MakeScheduleReleaseUI makeScheduleReleaseUI;
        private PurchaseManagerControl purchaseManagerControl;

        private ViewPPOControl viewPPOControl;

        private ScheduleReleaseAdapter scheduleReleaseAdapter;

        public MakeScheduleReleaseControl(PurchaseManagerControl purchaseManagerControl)
        {
            this.purchaseManagerControl = purchaseManagerControl;
            viewPPOControl = new ViewPPOControl();
            makeScheduleReleaseUI = new MakeScheduleReleaseUI(this, viewPPOControl.getPPODT(null, null));
            makeScheduleReleaseUI.MdiParent = purchaseManagerControl.getUI();
            makeScheduleReleaseUI.Show();
            scheduleReleaseAdapter = new ScheduleReleaseAdapter();
        }

        public void viewPPOItems(string PPOID)
        {
            new ViewPPOItemsControl(PPOID);
        }

        public void submit(ScheduleRelease scheduleRelease)
        {
            if(scheduleReleaseAdapter.addScheduleRelease(scheduleRelease))
            {
                Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + " purchase manager add schedule release with release number : " + scheduleRelease.GetReleaseNumber());
            }
        }

    }
}
