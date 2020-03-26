using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;
using PcSMS.Models;
using PcSMS.Models.ViewModels;
using PcSMS.Utility;

namespace PcSMS.Pages.Services
{
    [Authorize(Roles = Who.AdminAndStaff)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public VesselServiceViewModel VesselServiceVM { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGet(int vessId)
        {
            VesselServiceVM = new VesselServiceViewModel
            {
                Vessel = await _db.Vessel.Include(c => c.ApplicationUser).FirstOrDefaultAsync(c => c.Id == vessId),
                ServiceHeader = new Models.ServiceHeader()
            };

            List<String> lstServiceTypeInShoppingCart = _db.ServiceShoppingCart
                                                            .Include(c => c.ServiceType)
                                                            .Where(c => c.VesselId == vessId)
                                                            .Select(c => c.ServiceType.Name)
                                                            .ToList();

            IQueryable<ServiceType> lstService = from s in _db.ServiceType
                                                 where !(lstServiceTypeInShoppingCart.Contains(s.Name))
                                                 select s;

            VesselServiceVM.ServiceTypesList = lstService.ToList();

            VesselServiceVM.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.VesselId == vessId).ToList();
            VesselServiceVM.ServiceHeader.TotalPrice = 0;

            foreach (var item in VesselServiceVM.ServiceShoppingCart)
            {
                VesselServiceVM.ServiceHeader.TotalPrice += item.ServiceType.Price;
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                VesselServiceVM.ServiceHeader.DateAdded = DateTime.Now;
                VesselServiceVM.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.VesselId == VesselServiceVM.Vessel.Id).ToList();
                foreach (var item in VesselServiceVM.ServiceShoppingCart)
                {
                    VesselServiceVM.ServiceHeader.TotalPrice += item.ServiceType.Price;
                }
                VesselServiceVM.ServiceHeader.VesselId = VesselServiceVM.Vessel.Id;

                _db.ServiceHeader.Add(VesselServiceVM.ServiceHeader);
                await _db.SaveChangesAsync();

                foreach (var detail in VesselServiceVM.ServiceShoppingCart)
                {
                    ServiceDetails serviceDetails = new ServiceDetails
                    {
                        ServiceHeaderId = VesselServiceVM.ServiceHeader.Id,
                        ServiceName = detail.ServiceType.Name,
                        ServicePrice = detail.ServiceType.Price,
                        ServiceTypeId = detail.ServiceTypeId
                    };

                    _db.ServiceDetails.Add(serviceDetails);

                }
                _db.ServiceShoppingCart.RemoveRange(VesselServiceVM.ServiceShoppingCart);

                await _db.SaveChangesAsync();

                return RedirectToPage("../Vessels/Index", new { userId = VesselServiceVM.Vessel.UserId });
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAddToCart()
        {
            ServiceShoppingCart objServiceCart = new ServiceShoppingCart()
            {
                VesselId = VesselServiceVM.Vessel.Id,
                ServiceTypeId = VesselServiceVM.ServiceDetails.ServiceTypeId
            };

            _db.ServiceShoppingCart.Add(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { vessId = VesselServiceVM.Vessel.Id });
        }

        public async Task<IActionResult> OnPostRemoveFromCart(int serviceTypeId)
        {
            ServiceShoppingCart objServiceCart = _db.ServiceShoppingCart
                .FirstOrDefault(u => u.VesselId == VesselServiceVM.Vessel.Id && u.ServiceTypeId == serviceTypeId);


            _db.ServiceShoppingCart.Remove(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { vessId = VesselServiceVM.Vessel.Id });
        }
    }
}