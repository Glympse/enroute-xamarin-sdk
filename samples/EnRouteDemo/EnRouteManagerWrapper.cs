using System;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
	public class EnRouteManagerWrapper
	{
		private static EnRouteManagerWrapper instance;

		private GEnRouteFactory _enRouteFactory;

		private GEnRouteManager _enRouteManager;

		private EnRouteManagerWrapper ()
		{
		}

		public static EnRouteManagerWrapper Instance
		{
			get 
			{
				if (null == instance) 
				{
					instance = new EnRouteManagerWrapper();
				}
				return instance;
			}
		}

		public void create(GEnRouteFactory enRouteFactory)
		{
			if (null == _enRouteFactory || null == _enRouteManager) 
			{
				_enRouteFactory = enRouteFactory;
				_enRouteManager = _enRouteFactory.createEnRouteManager();
			}
		}

		public GEnRouteManager Manager
		{
			get 
			{
				return _enRouteManager;
			}
		}
	}
}

