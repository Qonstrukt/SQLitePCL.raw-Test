using System;
using Akavache;

namespace PCL
{
	public static class Cache
	{
		public static IBlobCache GetCache ()
		{
			BlobCache.ApplicationName = "Test";

			BlobCache.LocalMachine.InsertObject ("test", "dummy");

			return BlobCache.LocalMachine;
		}
	}
}

