using DMLOPerations_CS;
using PetapocoDMLOperations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetapocoDMLOperations.Models;
namespace PetapocoDMLOperations.Controllers
{
    public class AuctionsController : Controller
    {

		//public ActionResult Listing()
		//{
			
		//	List<Auction> model = new List<Auction>();
		//	model = AuctionsService.Instance.GetAuctions();
		//	return PartialView(model);
		//}

		// GET: Auctions
		public ActionResult Index()
        {
			AuctionsViewModel model = new AuctionsViewModel();
			model.Auctions = AuctionsService.Instance.GetAuctions();
			if (Request.IsAjaxRequest())
			{
				return PartialView(model);
			}
			else
			{
				return View(model);
			}
            
        }
		[HttpGet]
		public ActionResult Create()
		{
			return PartialView();
		}
		[HttpPost]
		public ActionResult Create(Auction auction)
		{
			AuctionsService.Instance.SaveAuctions(auction);
			return View();
		}
		[HttpGet]
		public ActionResult Edit(int Id)
		{
			Auction auction = AuctionsService.Instance.GetAuctionByID(Id);
			return PartialView(auction);
		}
		[HttpPost]
		public ActionResult Edit(Auction auction)
		{
			AuctionsService.Instance.UpdateAuctions(auction);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult Delete(int Id)
		{
			Auction auction = AuctionsService.Instance.GetAuctionByID(Id);
			return PartialView(auction);
		}
		[HttpPost]
		public ActionResult Delete(Auction auction)
		{
			AuctionsService.Instance.DeleteAuctions(auction);
			return RedirectToAction("Index");
		}
	}
}