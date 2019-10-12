    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using punto.Models;


    namespace punto.Controllers
    {
        public class VentaController : Controller
        {
            MyDbContext db = new MyDbContext();

            [HttpGet] 
            public ActionResult Index()
            {
                return View(db.Venta.ToList());
            }

            public ActionResult Create()
            {    
                var lista = new Producto();    
                lista.Listasnom = db.Producto.ToList();

                return View(lista);
            }   

            public IActionResult GetProduct(int id)
            {
                    var selectProduct = db.Producto.Find(id);
                    return Json(selectProduct);
            }

            [HttpPost]
            public JsonResult InsertVentas([FromBody]List<Venta> venta)
            {       
                //Check for NULL.
                if (venta == null)
                {
                    venta = new List<Venta>();
                }
        
                //Loop and insert records.
                foreach (Venta ventaa in venta)
                {
                    db.Venta.Add(ventaa);
                }
                int insertedRecords = db.SaveChanges();
                return Json(insertedRecords);
                
            }

            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Venta venta = db.Venta.Where(s => s.IdVenta == id).First();
                    db.Venta.Remove(venta);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }           
        }
    }