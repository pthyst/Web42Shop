using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Models;
using Web42Shop.ViewModels;
using Web42Shop.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Web42Shop.ModelsPayPal;

namespace Web42Shop.Controllers
{
    public class CheckoutController : Controller
    {
        private Web42ShopDbContext _context;
        public CheckoutController(Web42ShopDbContext context)
        {
            _context = context;
        }
        public bool IsLogedIn()
        {
            if (HttpContext.Session.GetString("TenTaiKhoan") != null){ return true;}
            else { return false;}
        }

        /*public async Task<IActionResult> Index()
        {
            List<CartItemViewModel> cartItem = new List<CartItemViewModel>();
            double sum = 0;

            if (HttpContext.Session.GetString("IdTaiKhoan") == null)
            {
                ViewBag.Hau = 1;
                if (HttpContext.Session.GetString("IdCart") != null)
                {
                    cartItem = await (from d in _context.AnoCartDetails
                                      join c in _context.AnoCarts
                                      on d.Cart_Id equals c.Id
                                      join p in _context.Products
                                      on d.Product_Id equals p.Id
                                      where c.Id == HttpContext.Session.GetInt32("IdCart")
                                      select new CartItemViewModel
                                      {
                                          Id = d.Id,
                                          Name = p.Name,
                                          Quantity = d.Quantity,
                                          Price = d.PriceSingle,
                                          TotalPrice = d.PriceTotal
                                      }).ToListAsync();
                }
                foreach (var item in cartItem){ sum += item.TotalPrice;}
            }
            else
            {
               cartItem = await (from d in _context.CartDetails
                                    join c in _context.Carts
                                    on d.Cart_Id equals c.Id
                                    join p in _context.Products
                                    on d.Product_Id equals p.Id
                                    where c.User_Id == HttpContext.Session.GetInt32("IdTaiKhoan")
                                    select new CartItemViewModel
                                    {
                                        Id = d.Id,
                                        Name = p.Name,
                                        Quantity = d.Quantity,
                                        Price = d.PriceSingle,
                                        TotalPrice = d.PriceTotal
                                    }).ToListAsync();
                foreach (var item in cartItem){ sum += item.TotalPrice;}
            }

            CartViewModel vm = new CartViewModel()
            {
                ProductTypes = _context.ProductTypes.ToList(),
                CartItemViewModels = cartItem
            };
            HttpContext.Session.SetString("TongTien", sum.ToString());
            string Ten= HttpContext.Session.GetString("TenTaiKhoan");
            string DiaChi = HttpContext.Session.GetString("diachi");
            ViewBag.ten = Ten;
            ViewBag.diachi = DiaChi;
            PayPalConfig payPalConfig = PayPalService.GetPayPalConfig();
            ViewBag.payPalConfig = payPalConfig;
            return View(vm);
        }*/

        public IActionResult Index()
        {
            
            int orderid = (int)HttpContext.Session.GetInt32("OrderId");
            List<OrderDetail> orderdetails = _context.OrderDetails.Where(o => o.Order_Id == orderid).ToList();

            List<Product> products = new List<Product>();
            foreach(var detail in orderdetails)
            {
                Product pro = _context.Products.Where(o => o.Id == detail.Product_Id).FirstOrDefault();
                products.Add(pro);
            }

            CheckoutIndexViewModel vm = new CheckoutIndexViewModel()
            {
                OrderDetails =  orderdetails,
                Products     = products,
                ProductTypes = _context.ProductTypes.ToList()
            };

            int sum = 0;
            foreach (var detail in vm.OrderDetails){ sum += detail.PriceTotal;}
            HttpContext.Session.SetString("TongTien", sum.ToString());

            PayPalConfig payPalConfig = PayPalService.GetPayPalConfig();
            ViewBag.payPalConfig = payPalConfig;

            return View(vm);
        }

        [HttpGet]
        public IActionResult MustSignUp(int anocartid)
        {
            CheckOutMustSignUpViewModel vm = new CheckOutMustSignUpViewModel()
            {
                User = new User(){ Role_Id = 4},
                AnoCartId = anocartid,
                ProductTypes = _context.ProductTypes.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult MustSignUp(CheckOutMustSignUpViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(vm.User);
                _context.SaveChanges();

                AnoCart anocart = _context.AnoCarts.Where(ac => ac.Id == vm.AnoCartId).FirstOrDefault();
    
                Cart cart = new Cart();
                int userid = _context.Users.Where(u => u.PhoneNumber == vm.User.PhoneNumber).FirstOrDefault().Id;
                
                cart.User_Id = userid;
                cart.CartStatus_Id = anocart.CartStatus_Id;
                cart.TotalQuantity = anocart.TotalQuantity;
                cart.TotalPrice    = anocart.TotalPrice;
                cart.DateCreate    = anocart.DateCreate;
                cart.DateModify    = anocart.DateModify;

                _context.Carts.Add(cart);
                _context.SaveChanges();                
                
                int cartid = _context.Carts.Where(c => c.User_Id == userid).FirstOrDefault().Id;
                
                if (_context.AnoCartDetails.Where(ac => ac.Cart_Id == anocart.Id).FirstOrDefault() != null)
                {
                    List<AnoCartDetail> anodetails = _context.AnoCartDetails.Where(ac => ac.Cart_Id == anocart.Id).ToList();
                    foreach(AnoCartDetail detail in anodetails)
                    {
                        CartDetail cdt  = new CartDetail(){
                            Cart_Id     = cartid,
                            Product_Id  = detail.Product_Id,
                            PriceSingle = detail.PriceSingle,
                            PriceTotal  = detail.PriceTotal,
                            Quantity    = detail.Quantity,
                            DateCreate  = detail.DateCreate,
                            DateModify  = detail.DateModify
                        };
                        _context.CartDetails.Add(cdt);
                        _context.SaveChanges();
                    }
                }

                return RedirectToAction("AlreadySignUp","Checkout",new {userid = userid});
            }
            else
            {
                return View(
                    new CheckOutMustSignUpViewModel()
                    {
                        User = vm.User,
                        AnoCartId = vm.AnoCartId,
                        ProductTypes = _context.ProductTypes.ToList()
                    }
                );
            }
        }

        [HttpGet]
        public IActionResult AlreadySignUp(int userid)
        {
            User user = _context.Users.Where(u => u.Id == userid).FirstOrDefault();
            Cart cart = _context.Carts.Where(c => c.User_Id == userid).FirstOrDefault();

            if (HttpContext.Session.GetString("Checking") != "true") // Để tránh tình trạng tự tạo order nhiều lần
            {
                Order order = new Order();
                order.User_Id          = user.Id;
                order.NameLast         = user.NameLast;
                order.NameMiddle       = user.NameMiddle;
                order.NameFirst        = user.NameFirst;
                order.AddressApartment = user.AddressApartment;
                order.AddressStreet    = user.AddressStreet;
                order.AddressDistrict  = user.AddressDistrict;
                order.AddressCity      = user.AddressCity;
                order.PhoneNumber      = user.PhoneNumber;
                order.OrderStatus_Id   = 1; // Trạng thái đơn hàng - Đang đợi xử lý - waiting
                order.PayStatus_Id     = 1; // Trạng thái thanh toán - Chưa thanh toán - notyet
                order.PayType_Id       = 1; // Hình thức thanh toán - Tiền mặt - cash
                order.DateCreate       = DateTime.Now;
                order.DateModify       = DateTime.Now;
                order.TotalPrice       = cart.TotalPrice;
                _context.Orders.Add(order);
                _context.SaveChanges();
                HttpContext.Session.SetString("Checking","true");

                var queryable = _context.Orders.Where(o => o.PhoneNumber == user.PhoneNumber);
                int orderid = queryable.Where(o => o.OrderStatus_Id == 1).FirstOrDefault().Id;
            
                List<CartDetail> details = _context.CartDetails.Where(cd => cd.Cart_Id == cart.Id).ToList();
                foreach(CartDetail detail in details)
                {
                    OrderDetail od = new OrderDetail();

                    od.Order_Id = orderid;
                    od.Product_Id = detail.Product_Id;
                    od.PriceSingle = detail.PriceSingle;
                    od.Quantity= detail.Quantity;
                    od.PriceTotal = detail.PriceTotal;

                    _context.OrderDetails.Add(od);
                    _context.SaveChanges();
                }
            }
         
            var queryable2 = _context.Orders.Where(o => o.PhoneNumber == user.PhoneNumber);
            int orderid2 = queryable2.Where(o => o.OrderStatus_Id == 1).FirstOrDefault().Id;
            HttpContext.Session.SetInt32("OrderId",orderid2);
            HttpContext.Session.SetInt32("IdTaiKhoan",user.Id);
            return RedirectToAction("Index");
        }

        public void ClearCart(int id)
        {
            Cart cart = _context.Carts.Where(c => c.Id == id).FirstOrDefault();
            List<CartDetail> details = _context.CartDetails.Where(cd => cd.Cart_Id == id).ToList();
            if (details != null)
            {
                foreach(CartDetail detail in details)
                {
                    _context.CartDetails.Remove(detail);
                    _context.SaveChanges();
                }
            }
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }

        public void ClearAnoCart(int id)
        {
            AnoCart cart = _context.AnoCarts.Where(c => c.Id == id).FirstOrDefault();
            List<AnoCartDetail> details = _context.AnoCartDetails.Where(cd => cd.Cart_Id == id).ToList();
            if (details != null)
            {
                foreach(AnoCartDetail detail in details)
                {
                    _context.AnoCartDetails.Remove(detail);
                    _context.SaveChanges();
                }
            }
            _context.AnoCarts.Remove(cart);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult PayPalPaid(int orderid)
        {
            Order order = _context.Orders.Where(o => o.Id == orderid).FirstOrDefault();
            order.PayStatus_Id = 2; // Đã thanh toán
            order.PayType_Id   = 2; // Loại thanh toán PayPal
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult NganLuongPaid(int orderid)
        {
            Order order = _context.Orders.Where(o => o.Id == orderid).FirstOrDefault();
            order.PayStatus_Id = 2; // Đã thanh toán
            order.PayType_Id   = 3; // Loại thanh toán Ngân lượng
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}