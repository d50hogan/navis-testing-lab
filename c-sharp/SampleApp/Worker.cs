namespace SampleApp
{
    public class Worker
    {
        private readonly IRepository _baseValue;

        public Worker(IRepository baseValue)
        {
            _baseValue = baseValue;
        }

        public int AddValueAndOne(int firstValue)
        {
            var returnedValue = firstValue + _baseValue.GetBaseValue();                              
            return returnedValue; 
        }
    }
}