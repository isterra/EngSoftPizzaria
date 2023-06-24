using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DataBaseModels;
using Services.Interface;

namespace Pizzaria.Controllers
{
    [ApiController]
    [Authorize(Roles = "admin,employee")]
    [Route("menu")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateMenuAsync(Menu createMenu)
        {
            var menu = await _menuService.CreateMenu(createMenu);
            return Ok(menu);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllItemsOfMenu()
        {
            var items = _menuService.GetAllItemsOfMenu();
            return Ok(items);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetItemByIdAsync(int id)
        {
            var item = await _menuService.GetItemById(id);
            return Ok(item);
        }
        [HttpPut]
        public async Task<IActionResult> EditMenuAsync(Menu menu)
        {
            var item = await _menuService.UpdateItem(menu);
            return Ok(item);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteItemByIdAsync(int id)
        {
            await _menuService.DeleteItemById(id);
            return Ok();
        }

    }
}
