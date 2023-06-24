using Microsoft.EntityFrameworkCore;
using Models.DataBaseModels;
using Services.DataBase;
using Services.Interface;

namespace Services
{
    public class MenuService : IMenuService
    {
        private readonly PostgreSql _postgreSql;

        public MenuService(PostgreSql postgreSql)
        {
                _postgreSql=postgreSql;
        }

        public async Task<Menu> CreateMenu(Menu menu)
        {
            await _postgreSql.Menu.AddAsync(menu);
            await _postgreSql.SaveChangesAsync();
            return menu;
        }

        public async Task<Menu> UpdateItem(Menu menu)
        {
            _postgreSql.Menu.Update(menu);
            await _postgreSql.SaveChangesAsync();
            return menu;
        }

        public async Task<Menu> GetItemById(int id)
        {
            var item = await _postgreSql.Menu.FirstOrDefaultAsync(m=>m.Id==id);
            await _postgreSql.SaveChangesAsync();
            return item;
        }

        public async Task<Menu> DeleteItemById(int id)
        {
            var item = await _postgreSql.Menu.Where(m => m.Id == id).FirstAsync();
            _postgreSql.Menu.Remove(item);
            await _postgreSql.SaveChangesAsync();
            return item;
        }

        public IList<Menu> GetAllItemsOfMenu()
        {
            var items = _postgreSql.Menu.ToList();
            return items;
        }
    }
}
