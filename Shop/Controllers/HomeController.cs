using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Shop.ViewModels;

namespace Shop.Controllers
{
    
    public class HomeController : Controller
    {
        private IGoodRepository _goodRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IGoodRepository goodRepository)
        {
            _logger = logger;
            this._goodRepository = goodRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var goodList = _goodRepository.Goods().ToList();



            List<GoodsViewModel> goodsViewModelsList = new List<GoodsViewModel>();
            ConvertGoodListToGoodViewModelList(goodList, goodsViewModelsList);

            return View(goodsViewModelsList);
           
        }

        private static void ConvertGoodListToGoodViewModelList(List<Goods> goodList, List<GoodsViewModel> goodsViewModelsList)
        {
            foreach (Goods g in goodList)
            {
                goodsViewModelsList.Add(new GoodsViewModel(g));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
