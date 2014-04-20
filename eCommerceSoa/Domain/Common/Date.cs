namespace Domain
{
    public class Date
    {
        public byte Day { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }

        public override string ToString()
        {
            return base.ToString();
            //todo
        }
    }
}