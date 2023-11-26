using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
{
	options.LoginPath = "/Pages/LogIn";
	options.LogoutPath = "/Pages/LogOut";
});
builder.Services.Configure<CookiePolicyOptions>(options =>
{
	options.MinimumSameSitePolicy = SameSiteMode.None;
	options.HttpOnly = HttpOnlyPolicy.Always;
	options.Secure = CookieSecurePolicy.Always;
});
builder.Services.AddSession(options => {
	options.IdleTimeout = TimeSpan.FromMinutes(10);
}) ;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();
app.UseAuthentication();

app.UseCookiePolicy();

app.MapRazorPages();

app.UseSession();

app.Run();
