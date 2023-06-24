using Models.DataBaseModels;

namespace Services.Interface
{
    public interface IMenuService
    {
        Task<Menu> CreateMenu(Menu menu);
        Task<Menu> UpdateItem(Menu menu);
        Task<Menu> GetItemById(int id);
        Task<Menu> DeleteItemById(int id);
        IList<Menu> GetAllItemsOfMenu();

    }
}
