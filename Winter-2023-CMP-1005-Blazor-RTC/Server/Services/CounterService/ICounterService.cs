namespace Winter_2023_CMP_1005_Blazor_RTC.Server.Services.CounterService
{
     public interface ICounterService
    {
        /// <summary>
        /// Returns the count of the service.
        /// </summary>
        /// <returns>The count of the service.</returns>
        int GetCount();

        /// <summary>
        /// Adds the <paramref name="numberToAdd"> to the counter and returns the value.
        /// </summary>
        /// <param name="numberToAdd">Number to add to the counter.</param>
        /// <returns>The new counter value after the <paramref name="numberToAdd"> has been added.</returns>
        int AddToCount(int numberToAdd);
    }
}
