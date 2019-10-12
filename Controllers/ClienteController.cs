    using System.Linq;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using punto.Models;

    namespace punto.Controllers
    {
        public class ClienteController : Controller
        {
            MyDbContext db = new MyDbContext();
            public ActionResult Index()
            {
                return View(db.Cliente.ToList());
            }
            public ActionResult Create()
            {
                var lista = new Cliente();    
                lista.ListasCli = db.Cliente.ToList();

                return View(lista);
            }
            [HttpPost]
            public ActionResult CreateCliente(Cliente cliente){
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index", "Cliente");
            }
            [HttpPost]
            public bool Delete(int id){
                try
                {
                    Cliente cliente = db.Cliente.Where(s => s.IdCliente == id).First();
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            public ActionResult Update(int id){
                return View(db.Cliente.Where(s => s.IdCliente == id).First());
            }
            [HttpPost]
            public ActionResult UpdateCliente(Cliente cliente){
                Cliente d = db.Cliente.Where(s => s.IdCliente == cliente.IdCliente).First();
                d.Nombre = cliente.Nombre;
                d.Apellido = cliente.Apellido;
                d.Nit = cliente.Nit;
                d.Direccion = cliente.Direccion;
                db.SaveChanges();
                return RedirectToAction("Index", "Cliente");
            }
        }
    }