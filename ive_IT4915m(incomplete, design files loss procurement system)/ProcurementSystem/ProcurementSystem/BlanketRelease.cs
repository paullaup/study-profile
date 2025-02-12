using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class BlanketRelease : PurchaseOrder
    {
        private int releaseNumber;
        private string BPAID;
        private DateTime createdDate;
        private string shipAddress;
        private DateTime expectedDeliveryDate;
        private Account account;
        private int actualAmount;
        private int actualQuantity;

        private BlanketReleaseAdapter blanketReleaseAdapter;

        public BlanketRelease(string BPAID, DateTime createdDate, string shipAddress, DateTime expectedDeliveryDate, int actualAmount, int actualQuantity)
        {
            blanketReleaseAdapter = new BlanketReleaseAdapter();
            this.BPAID = BPAID;
            this.createdDate = createdDate;
            this.shipAddress = shipAddress;
            this.expectedDeliveryDate = expectedDeliveryDate;
            this.actualAmount = actualAmount;
            this.actualQuantity = actualQuantity;
            releaseNumber = -1;
        }

        public override int getPONumber()
        {
            if(releaseNumber == -1)
            {
                releaseNumber = blanketReleaseAdapter.getLatestReleaseNumber() + 1;
            }
            return releaseNumber;
        }

        public void SetReleaseNumber(int releaseNumber)
        {
            this.releaseNumber = releaseNumber;
        }

        public string GetBPAID()
        {
            return BPAID;
        }

        public void SetBPAID(string BPAID)
        {
            this.BPAID = BPAID;
        }

        public DateTime GetCreatedDate()
        {
            return createdDate;
        }

        public void SetCreatedDate(DateTime createdDate)
        {
            this.createdDate = createdDate;
        }

        public string GetShipAddress()
        {
            return shipAddress;
        }

        public void SetShipAddress(string shipAddress)
        {
            this.shipAddress = shipAddress;
        }

        public DateTime GetExpectedDeliveryDate()
        {
            return expectedDeliveryDate;
        }

        public void SetExpectedDeliveryDate(DateTime expectedDeliveryDate)
        {
            this.expectedDeliveryDate = expectedDeliveryDate;
        }

        public Account GetAccount()
        {
            return account;
        }

        public void SetAccount(Account account)
        {
            this.account = account;
        }

        public int GetActualAmount()
        {
            return actualAmount;
        }

        public void SetActualAmount(int actualAmount)
        {
            this.actualAmount = actualAmount;
        }

        public int GetActualQuantity()
        {
            return actualQuantity;
        }

        public void SetActualQuantity(int actualQuantity)
        {
            this.actualQuantity = actualQuantity;
        }

    }
}
