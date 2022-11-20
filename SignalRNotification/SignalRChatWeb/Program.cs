using SignalRChatWeb.Hubs;

var builder = WebApplication.CreateBuilder(args);

// ******* *****************************
// Kestrel: declare to use Kestrel on deployment
// load default kestrel endpoint url setting from 
// appsettings.json
builder.WebHost.UseKestrel(); 

// SigalR: manual added signalR dependency
builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// SignalR: add chathub
app.MapHub<ChatHub>("/chathub");
app.Run();
