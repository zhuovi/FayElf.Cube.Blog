using XiaoFeng.Mvc.AdminWinDesk;

await ApplicationManager.Load(args).RunAsync(() => WebHost.CreateHost(args, services =>
{
#if DEBUG
	services.AddControllersWithViews().AddRazorRuntimeCompilation();
#endif
	//JSONÅäÖÃ
	services.ConfigureJsonSerializerOptions();
}, app =>
{
	app.UseAdminWinDesk(app.Environment);

}, init: true));