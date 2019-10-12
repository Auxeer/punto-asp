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
        public class PedidoController : Controller
        {
            MyDbContext db = new MyDbContext();

           [HttpGet] 
            public ActionResult Index()
            {
                return View(db.Pedido.ToList());
            }

            public ActionResult Create()
            {    
                var lista = new Producto();    
                lista.Listasnom = db.Producto.ToList();

                return View(lista);
            }  

            [HttpPost]
            public ActionResult Create(Producto producto)
            {    
                var lista = new Producto();     
                lista.Listasnom = db.Producto.ToList();

                var emp = lista.Listasnom.Where(e => e.Id == producto.Id).FirstOrDefault();

                lista.Id = emp.Id;
                lista.Nombre = emp.Nombre; 
                lista.Precio = emp.Precio;

                return View(lista);                
            }  

            public IActionResult GetProduct(int id)
            {
                    var selectProduct = db.Producto.Find(id);
                    return Json(selectProduct);
            }

            [HttpPost]
            public JsonResult InsertPedidos([FromBody]List<Pedido> pedido)
            {       
                //Check for NULL.
                if (pedido == null)
                {
                    pedido = new List<Pedido>();
                }
        
                //Loop and insert records.
                foreach (Pedido pedidoo in pedido)
                {
                    db.Pedido.Add(pedidoo);
                }
                int insertedRecords = db.SaveChanges();
                return Json(insertedRecords);
                
            }

            [HttpPost]
            public ActionResult CreatePedido(Pedido pedido){
                db.Pedido.Add(pedido);
                db.SaveChanges();
                return RedirectToAction("Index", "Pedido");
            }
            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Pedido pedido = db.Pedido.Where(s => s.IdPedido == id).First();
                    db.Pedido.Remove(pedido);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            public ActionResult Update(int id){
                return View(db.Pedido.Where(s => s.IdPedido == id).First());
            }
            [HttpPost]
            public ActionResult UpdatePedido(Pedido pedido){
                Pedido d = db.Pedido.Where(s => s.IdPedido == pedido.IdPedido).First();
                d.Producto = pedido.Producto;
                d.CantidadPedido = pedido.CantidadPedido;
                d.Estado = pedido.Estado;
                db.SaveChanges();
                return RedirectToAction("Index", "Pedido");
            }
        }
    }