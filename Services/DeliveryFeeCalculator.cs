namespace ParcelTrack.Services
{
    public class DeliveryFeeCalculator : IDeliveryFeeCalculator
    {
        private const decimal BaseFee = 500m;
        private const decimal PerKg = 150m;
        private const decimal OutsideKingstonFee = 300m;

        private static readonly string[] KingstonParishes = { "Kingston", "St Andrew" };

        public decimal CalculateFee(double weightKg, string? parish)
        {
            decimal wholeKg = (decimal)Math.Ceiling(weightKg);
            decimal fee = BaseFee + wholeKg * PerKg;

            if (!KingstonParishes.Contains(parish))
            {
                fee += OutsideKingstonFee;
            }
            return fee;
        }
    }
}
