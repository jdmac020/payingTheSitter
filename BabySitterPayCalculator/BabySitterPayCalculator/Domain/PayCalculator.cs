namespace BabySitterPayCalculator.Domain
{
    public class PayCalculator
    {
        private int _startHour;
        private int _endHour;

        private const int _afternoonRate = 7;
        private const int _eveningRate = 11;
        private const int _nightRate = 13;
        private const int _eveningStart = 5;
        private const int _nightStart = 10;

        public PayCalculator(int startHour, int endHour)
        {
            _startHour = startHour;
            _endHour = endHour;
        }

        public int CalculatePay()
        {
            var totalPay = 0;

            for (var hour = _startHour; hour < _endHour; hour++)
            {
                if (hour < _eveningStart)
                {
                    totalPay += _afternoonRate;
                }
                else if (hour < _nightStart)
                {
                    totalPay += _eveningRate;
                }
                else
                {
                    totalPay += _nightRate;
                }
            }

            return totalPay;
        }
    }
}