using DMLOPerations_CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetapocoDMLOperations.Helpers
{
	public static class DataContextHelper
	{
		public static DMLOPerations_CSDB GetPPDataContext(bool enableAutoSelect = true)
		{
			return (GetNewDataContext("DMLOPerations_CS", enableAutoSelect));
		}
		private static DMLOPerations_CSDB GetNewDataContext(string connectionStringName, bool enableAuctoSelect)
		{
			DMLOPerations_CSDB repository = new DMLOPerations_CSDB(connectionStringName);
			repository.EnableAutoSelect = enableAuctoSelect;
			return (repository);
		}

	}
}