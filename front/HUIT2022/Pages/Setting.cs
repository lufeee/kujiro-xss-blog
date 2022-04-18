﻿namespace HUIT2022.Pages
{
	public static class Setting
	{
		public static readonly string HostAddr = (
			Environment.GetEnvironmentVariable("PROTOCOL") + "://" +
			Environment.GetEnvironmentVariable("URL_API")
		);
	}
}
