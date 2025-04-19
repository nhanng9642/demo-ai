namespace product_management.dto
{
    public class Category : Entity
    {
        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name}";
        }
    }
}
