using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//AddSingelton :arka planda referans olu?turma 
//Controllerde IProuctService �a?r?ld???nda arka planda ProductManager olu?tur onu ver
//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();

//.Net Core yerine ba?ka bir IoC container kullanma
//Bu kod, ASP.NET Core uygulaman?zda Autofac'i bir ba??ml?l?k enjeksiyon (DI) konteyneri
//olarak yap?land?r?r. AutofacBusinessModule,
//uygulaman?n ihtiya� duydu?u servislerin ve ba??ml?l?klar?n nas?l ��z�mlenece?ini tan?mlar.
//B�ylece uygulama �al??t???nda gerekli olan t�m ba??ml?l?klar Autofac taraf?ndan otomatik
//olarak sa?lan?r.
builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory()).
    ConfigureContainer<ContainerBuilder>(builder => 
    { 
        builder.RegisterModule(new AutofacBusinessModule()); 
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
