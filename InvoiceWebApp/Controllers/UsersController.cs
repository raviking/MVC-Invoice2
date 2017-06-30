using InvoiceWebApp.Data;
using InvoiceWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceWebApp.Controllers {

    public class UsersController : Controller {
        private ApplicationDbContext _context;
        private AppSettings _settings;
        private IHostingEnvironment _env;

        public UsersController(ApplicationDbContext context, IHostingEnvironment env) {
            _context = context;
            _env = env;
            _settings = _context.Settings.SingleOrDefault();
        }

        /*----------------------------------------------------------------------*/
        //DATABASE ACTION METHODS

        private async Task<List<User>> GetUsers() {
            List<User> userList = await _context.Users.Include(s => s.Debtor).ToListAsync();
            return userList;
        }

        private async Task<User> GetUser(int? id) {
            User user = null;

            try {
                user = await _context.Users.Include(s => s.Debtor).SingleOrDefaultAsync(s => s.ID == id);
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }

            return user;
        }

        private async Task CreateUser(User user) {
            user.AccountType = "Client";

            try {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }

        private async Task UpdateUser(User user) {
            try {
                _context.Update(user);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException ex) {
                Debug.WriteLine(ex);
            }
        }

        private async Task DeleteUser(int id) {
            User user = await GetUser(id);

            try {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }

        /*----------------------------------------------------------------------*/
        //CONTROLLER ACTIONS

        // GET: User
        public async Task<IActionResult> Index(string sortOrder, string searchQuery) {
            //CURRENT PAGE
            ViewBag.Current = "Users";

            //SORTING OPTIONS ADMIN LIST
            ViewBag.BeginSortParm = String.IsNullOrEmpty(sortOrder) ? "begin_desc" : "";
            ViewBag.FirstNameSortParm = sortOrder == "FirstName" ? "firstname_desc" : "FirstName";
            ViewBag.LastNameSortParm = sortOrder == "LastName" ? "lastname_desc" : "LastName";
            ViewBag.EmailSortParm = sortOrder == "Email" ? "email_desc" : "Email";

            var users = await GetUsers();
            var query = from user in users
                        select user;

            //SEARCH OPTION ADMIN LIST
            if (!String.IsNullOrEmpty(searchQuery)) {
                query = query.Where(s => s.Debtor.FirstName.Contains(searchQuery)
                                       || s.Email.Contains(searchQuery)
                                       || s.Debtor.LastName.Contains(searchQuery)
                                       || s.Debtor.City.Contains(searchQuery)
                                       || s.Debtor.PostalCode.Contains(searchQuery)
                                       || s.Debtor.Country.Contains(searchQuery));
            }

            switch (sortOrder) {
                //WHEN NO SORT
                case "begin_desc":
                    query = query.OrderByDescending(s => s.Debtor.LastName);
                    break;
                //FIRST NAME
                case "FirstName":
                    query = query.OrderBy(s => s.Debtor.FirstName);
                    break;

                case "firstname_desc":
                    query = query.OrderByDescending(s => s.Debtor.FirstName);
                    break;
                //EMAIL
                case "Email":
                    query = query.OrderBy(s => s.Email);
                    break;

                case "email_desc":
                    query = query.OrderByDescending(s => s.Email);
                    break;
                //CITY
                case "LastName":
                    query = query.OrderBy(s => s.Debtor.LastName);
                    break;

                case "lastname_desc":
                    query = query.OrderByDescending(s => s.Debtor.LastName);
                    break;
                //DEFAUlT
                default:
                    query = query.OrderBy(s => s.Debtor.LastName);
                    break;
            }

            return View(query);
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var user = await GetUser(id);

            if (user == null) {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create() {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,Password")] User user) {
            if (ModelState.IsValid) {
                await CreateUser(user);
                return RedirectToAction("Login", "Users", new { area = "" });
            }

            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            //CURRENT PAGE
            ViewBag.Current = "UserManage";

            if (id == null) {
                return NotFound();
            }

            var user = await GetUser(id);

            if (user == null) {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AccountType,Address,City,Country,Email,FirstName,LastName,Password,PostalCode")] User user) {
            if (id != user.ID) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                await UpdateUser(user);

                User currentUser = SessionHelper.Get<User>(this.HttpContext.Session, "User");
                return RedirectToAction("Index", "Home", new { email = currentUser.Email });
            }

            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var user = await GetUser(id);

            if (user == null) {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            await DeleteUser(id);
            return RedirectToAction("Login", "Users", new { area = "" });
        }

        private bool UserExists(int id) {
            return _context.Users.Any(e => e.ID == id);
        }

        //GET: User/Login
        public ActionResult Login() {
            //CURRENT PAGE
            ViewBag.Current = "Login";

            return View();
        }

        //POST: User/Login
        [HttpPost]
        public ActionResult Login(User user) {
            User userLogin = null;
            Admin adminLogin = null;
            Debtor debtor = null;

            try {
                userLogin = _context.Users.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);

                if (userLogin != null) {
                    debtor = _context.Debtors.SingleOrDefault(d => d.DebtorID == userLogin.DebtorID);
                    userLogin.Debtor = debtor;
                } else {
                    adminLogin = _context.Admins.SingleOrDefault(u => u.Email == user.Email 
                                                    && u.Password == user.Password);
                }
                
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }

            if (userLogin != null) {
                SessionHelper.Set(this.HttpContext.Session, "User", userLogin);
                return RedirectToAction("Index", "Home", new { email = userLogin.Email });
            }
            if (adminLogin != null) {
                SessionHelper.Set(this.HttpContext.Session, "Admin", adminLogin);
                return RedirectToAction("Index", "Home", new { email = adminLogin.Email });
            }

            return View(userLogin);
        }

        //GET: User/Logout
        public ActionResult Logout() {
            HttpContext.Session.Remove("User");
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login", "Users", new { area = "" });
        }

        //GET: User/ForgotPassword
        public ActionResult ForgotPassword() {
            //CURRENT PAGE
            ViewBag.Current = "Login";

            return View();
        }

        //POST: User/ForgotPassword
        [HttpPost]
        public ActionResult ForgotPassword(string email, string password) {
            User userLogin = null;
            Admin adminLogin = null;

            try {
                userLogin = _context.Users.SingleOrDefault(s => s.Email == email);

                if (userLogin == null) {
                    adminLogin = _context.Admins.SingleOrDefault(s => s.Email == email);
                }
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }

            if (userLogin == null && adminLogin == null) {
                return NotFound();
            }

            try {
                if (userLogin != null) {
                    userLogin.Password = password;
                    _context.Update(userLogin);
                    
                } else if (adminLogin != null) {
                    adminLogin.Password = password;
                    _context.Update(adminLogin);
                }

                _context.SaveChanges();

                return RedirectToAction("Login", "Users", new { area = "" });
            } catch (Exception ex) {
                Debug.WriteLine(ex);
                return View(userLogin);
            }
        }


    }
}