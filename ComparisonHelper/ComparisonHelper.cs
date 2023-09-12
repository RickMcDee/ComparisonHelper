namespace ComparisonHelper
{
    public static class ComparisonHelper
    {
        public static T TakeNewValueIfChanged<T>(T value, T newValue, ref int updateCount)
        {
            if (EqualityComparer<T>.Default.Equals(value, newValue) is false)
            {
                updateCount++;
                return newValue;
            }

            return value;
        }

        public static T TakeNewValueIfChanged<T>(T value, T newValue)
        {
            if (EqualityComparer<T>.Default.Equals(value, newValue) is false)
            {
                return newValue;
            }

            return value;
        }

        public static T TakeNewValueIfNull<T>(T value, T newValue, ref int updateCount)
        {
            if (value is null)
            {
                updateCount++;
                return newValue;
            }

            return value;
        }

        public static T TakeNewValueIfNull<T>(T value, T newValue)
        {
            if (value is null)
            {
                return newValue;
            }

            return value;
        }
    }
}