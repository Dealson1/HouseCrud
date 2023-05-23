namespace House.Models
{
    public class HouseListViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Address { get; set; }
        public int Floors { get; set; }
    }
}
