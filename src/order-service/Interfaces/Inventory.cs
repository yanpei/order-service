namespace order_service.Controllers
{
    public class Inventory
    {
        public string ProductId{get; private set;}
        public int ActualCount{get; private set;}
        public int LockedCount{get;private set;}

        public Inventory(string productId, int actualCount, int lockedCount)
        {
            this.ProductId = productId;
            this.ActualCount = actualCount;
            this.LockedCount = lockedCount;
        }

        public void IncreaseActualCount(int count){
            this.ActualCount += count;
        }

        public void DecreaseActualCount(int count){
            this.ActualCount -= count;
        }
        public void IncreaseLockedCount(int count){
            this.LockedCount += count;
        }

        public void DecreaseLockedCount(int count){
            this.LockedCount -= count;
        }

        

    }
}