using MovieStoreProject.Entities;

namespace MovieStoreProject.Models.CustomerModels
{
    public class AddCustomerModel
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public CategoryEnum FavouriteCategories { get; set; }
    }
}
