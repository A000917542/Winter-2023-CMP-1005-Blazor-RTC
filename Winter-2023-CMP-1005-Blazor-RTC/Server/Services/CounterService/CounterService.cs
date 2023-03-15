namespace Winter_2023_CMP_1005_Blazor_RTC.Server.Services.CounterService
{
    public class CounterService : ICounterService
    {
        private int _counter = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberToAdd"></param>
        /// <returns></returns>
        public int AddToCount(int numberToAdd)
        {
            _counter += numberToAdd;
            return _counter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return _counter;
        }
    }
}
