using System;

namespace ProcurementSystem
{
    internal class ScheduleRelease
    {
        private int releaseNumber;
        private string PPOID;
        private DateTime createdDate;
        private DateTime expectedDeliveryDate;

        private ScheduleReleaseAdapter scheduleReleaseAdapter;

        public ScheduleRelease(string pPOID, DateTime expectedDeliveryDate)
        {
            PPOID = pPOID;
            this.createdDate = DateTime.Now;
            this.expectedDeliveryDate = expectedDeliveryDate;
            scheduleReleaseAdapter = new ScheduleReleaseAdapter();
            releaseNumber = scheduleReleaseAdapter.getLatestReleaseNumber();
        }

        public int GetReleaseNumber()
        {
            return releaseNumber;
        }

        public void SetReleaseNumber(int releaseNumber)
        {
            this.releaseNumber = releaseNumber;
        }

        public string GetPPOID()
        {
            return PPOID;
        }

        public void SetPPOID(string pPOID)
        {
            PPOID = pPOID;
        }

        public DateTime GetCreatedDate()
        {
            return createdDate;
        }

        public void SetCreatedDate(DateTime createdDate)
        {
            this.createdDate = createdDate;
        }

        public DateTime GetExpectedDeliveryDate()
        {
            return expectedDeliveryDate;
        }

        public void SetExpectedDeliveryDate(DateTime expectedDeliveryDate)
        {
            this.expectedDeliveryDate = expectedDeliveryDate;
        }
    }
}
