var builder = WebApplication.CreateBuilder(args);

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
//app.MapControllerRoute(
//    name: "MoviesByReleaseDate",
//    pattern: "{controller=Movies}/{action=ByReleaseDate}/{year}/{month}");

//app.MapControllerRoute(
//    name: "MoviesByReleaseDate",
//    pattern: "Movies/Released/{year}/{month}",
//    defaults: new { controller = "Movies", action = "ByReleaseDate"},
//    new {year = @"2015|2016|2017", month = @"\d{2}"}); 


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers();
app.Run();
