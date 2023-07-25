using FactoryPlatform.Data.AppDbContext;
using System;

namespace FactoryPlatform.Library.Quality.ControlPanel
{
    public class LModelSequences : ListObjects
	{
		public LModelSequences(StoresProceduresDbContext spContext)
		{
			_SpContext = spContext;
		}

	}
}
