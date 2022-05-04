namespace USN_DataLogging.DataTypes
{
    public class TagMeasurement
    {
        public int TagId { get; set; }
        public double Value { get; set; }
        public Quality Quality { get; set; }
        public string Unit { get; set; }
    }
}
