using DMLOPerations_CS;
using PetapocoDMLOperations.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetapocoDMLOperations.Services
{
	public class AuctionsService
	{
		#region Define as Singleton
		private static AuctionsService _Instance;
		public static AuctionsService Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new AuctionsService();
				}

				return (_Instance);
			}
		}
		private AuctionsService()
		{
		}
		#endregion

		public List<Auction> GetAuctions()
		{
			List<Auction> result;

			using (var repo = DataContextHelper.GetPPDataContext())
			{
				var ppSql = PetaPoco.Sql.Builder.Select(@"*").From("Auctions a");
				result = repo.Fetch<Auction>(ppSql).ToList();
				return result;
			}
		}
		public Auction GetAuctionByID(int Id)
		{
			using (var repo = DataContextHelper.GetPPDataContext())
			{
				return (repo.SingleOrDefault<Auction>(Id));
			}
		}
		public void SaveAuctions(Auction auction)
		{
			using (var repo = DataContextHelper.GetPPDataContext())
			{
				repo.Insert(auction);
			}
		}
		public void UpdateAuctions(Auction auction)
		{
			using (var repo = DataContextHelper.GetPPDataContext())
			{
				repo.Update(auction);
			}
		}
		public void DeleteAuctions(Auction auction)
		{
			using (var repo = DataContextHelper.GetPPDataContext())
			{
				repo.Delete(auction);
			}
		}

	}
}