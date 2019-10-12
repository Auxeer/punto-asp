    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using punto.Models;


    namespace punto.Controllers
    {
        public class ProductoController : Controller
        {
            MyDbContext db = new MyDbContext();

           [HttpGet] 
            public ActionResult Index()
            {
                return View(db.Producto.ToList());
            }

            public ActionResult Create()
            {               
                return View();
            }
            [HttpPost]
            public ActionResult CreateProducto(Producto producto){
                db.Producto.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index", "Producto");
            }
            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Producto producto = db.Producto.Where(s => s.Id == id).First();
                    db.Producto.Remove(producto);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            public ActionResult Update(int id){
                return View(db.Producto.Where(s => s.Id == id).First());
            }
            [HttpPost]
            public ActionResult UpdateProducto(Producto producto){
                Producto d = db.Producto.Where(s => s.Id == producto.Id).First();
                d.Nombre = producto.Nombre;
                d.Descripcion = producto.Descripcion;
                d.Precio = producto.Precio;
                db.SaveChanges();
                return RedirectToAction("Index", "Producto");
            }
        }
    }