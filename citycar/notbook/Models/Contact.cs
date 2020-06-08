namespace notbook.Models
{
    public class Contact : BaseEntity
    {
        public string Value { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        

        public int ContactTypeId { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}