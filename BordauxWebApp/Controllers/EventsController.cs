using System;
using System.Linq;
using System.Threading.Tasks;
using BordauxWebApp.Data;
using BordauxLib.Entities;
using BordauxWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BordauxWebApp.Controllers
{
    [Authorize(Roles = "Promotor, Admin")]
    public class EventsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly BordauxContext _context;

        public EventsController(UserManager<ApplicationUser> userManager, BordauxContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Overview()
        {
            var model = _context.Events
                .Select(e => new EventsEventVM()
                {
                    Id = e.Id,
                    Name = e.Name,
                    City = e.City,
                    StartDate = e.StartDate
                })
                .ToList();

            ViewBag.Title = "Events";

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            var acts = _context.Acts;

            var model = new EventsCreateEventVM()
            {
                Acts = acts.Select(a => new EventsActVM()
                {
                    ActId = a.Id,
                    ActName = a.Name,
                    IsChecked = false
                })
                .ToList()
            };

            ViewBag.Title = "Create event";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(EventsCreateEventVM model)
        {
            if (ModelState.IsValid)
            {
                var e = new Event()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    DateCreated = DateTime.Today,
                    StartDate = model.StartDate.Date,
                    EndDate = model.EndDate.Date,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    Promotor = _context.Promotors.Find((await GetCurrentUserAsync()).Id),
                    AddressLine = model.AddressLine,
                    PostalCode = model.PostalCode,
                    City = model.City
                };

                _context.Events.Add(e);
                _context.EventActs.AddRange(
                    model.Acts
                        .Where(a => a.IsChecked)
                        .Select(a => _context.Acts.Find(a.ActId))
                        .Select(a => new EventAct()
                        {
                            Act = a,
                            Event = e
                        }));
                _context.SaveChanges();

                return RedirectToAction("Overview");
            }

            ViewBag.Title = "Create Event";

            return View(model);
        }

        [HttpGet]
        [Route("Events/Details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var ev = _context.Events
                .Include(e => e.Promotor)
                .SingleOrDefault(e => e.Id == id);

            var acts = _context.EventActs
                .Where(ea => ea.EventId == ev.Id)
                .Include(ea => ea.Event)
                .Select(ea => _context.Acts
                    .SingleOrDefault(a => a.Id == ea.ActId))
                .ToList();

            var model = new EventsDetailsVM()
            {
                Id = ev.Id,
                Name = ev.Name,
                AddressLine = ev.AddressLine,
                PostalCode = ev.PostalCode,
                City = ev.City,
                Start = $"{ev.StartDate.ToShortDateString()} {string.Format("{0:00}:{1:00}", ev.StartTime.Hours, ev.StartTime.Minutes)}",
                End = $"{ev.EndDate.ToShortDateString()} {string.Format("{0:00}:{1:00}", ev.EndTime.Hours, ev.EndTime.Minutes)}",
                Promotor = ev.Promotor?.Email ?? "",
                PromotorId = ev.Promotor?.Id ?? "",
                LoggedInUserId = (await GetCurrentUserAsync()).Id,
                Acts = acts
            };

            ViewBag.Title = "Event details";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyEvents()
        {
            var user = await GetCurrentUserAsync();
            var model = _context.Events
                .Where(e => e.Promotor.Id == user.Id)
                .Select(e => new EventsEventVM()
                {
                    Id = e.Id,
                    Name = e.Name,
                    City = e.City,
                    StartDate = e.StartDate
                })
                .ToList();

            ViewBag.Title = "My events";

            return View(model);
        }

        [HttpGet]
        [Route("Events/UpdateEvent/{id}")]
        public IActionResult UpdateEvent(Guid id)
        {
            var ev = _context.Events.
                Include(e => e.Acts)
                    .ThenInclude(ea => ea.Act)
                .SingleOrDefault(e => e.Id == id);

            var actsFromEvent = ev.Acts.Select(ea => ea.Act);

            var model = new EventsUpdateEventVM()
            {
                Id = ev.Id,
                Name = ev.Name,
                AddressLine = ev.AddressLine,
                PostalCode = ev.PostalCode,
                City = ev.City,
                StartDate = ev.StartDate.Date,
                EndDate = ev.EndDate.Date,
                StartTime = ev.StartTime,
                EndTime = ev.EndTime,
                Acts = _context.Acts.Select(a => new EventsEventActVM()
                {
                    Name = a.Name,
                    Id = a.Id,
                    IsChecked = actsFromEvent.Contains(a)
                }).ToList()
            };

            ViewBag.Title = "Update event";

            return View(model);
        }

        [HttpPost]
        [Route("Events/UpdateEvent/{id}")]
        public IActionResult UpdateEvent(EventsUpdateEventVM model)
        {
            if (ModelState.IsValid)
            {
                var ev = _context.Events
                .Where(e => e.Id == model.Id)
                .Include(e => e.Acts)
                    .ThenInclude(ea => ea.Act)
                .Single();

                ev.Name = model.Name;
                ev.AddressLine = model.AddressLine;
                ev.PostalCode = model.PostalCode;
                ev.City = model.City;
                ev.StartDate = model.StartDate;
                ev.EndDate = model.EndDate;
                ev.StartTime = model.StartTime;
                ev.EndTime = model.EndTime;

                if (model.Acts != null)
                {
                    foreach (var act in model.Acts)
                    {
                        var a = _context.EventActs.SingleOrDefault(ea => ea.ActId == act.Id && ea.EventId == ev.Id);

                        if (act.IsChecked)
                        {
                            if (a == null)
                            {
                                _context.EventActs.Add(new EventAct()
                                {
                                    Act = _context.Acts.FirstOrDefault(ac => ac.Id == act.Id),
                                    Event = ev
                                });
                            }
                        }
                        else
                        {
                            if (a != null)
                            {
                                _context.EventActs.Remove(a);
                            }
                        }
                    }
                }

                _context.SaveChanges();

                TempData["EventUpdated"] = $"Act {ev.Name} has been updated.";

                return RedirectToAction("Details", new { id = ev.Id });
            }


            ViewBag.Title = "Update event";

            return View(model);
        }

        [HttpGet]
        [Route("Events/ConfirmDeleteEvent/{id}")]
        public async Task<IActionResult> ConfirmDeleteEvent(Guid id)
        {
            var ev = _context.Events
                .Include(e => e.Promotor)
                .SingleOrDefault(e => e.Id == id);

            if (ev == null)
            {
                TempData["EventNotFound"] = $"Event with id {id} does not exist.";

                return RedirectToAction("Overview");
            }

            if ((await GetCurrentUserAsync()).Id != ev.Promotor.Id && !await _userManager.IsInRoleAsync(await GetCurrentUserAsync(), "Admin"))
            {
                TempData["NoPermission"] = $"You have no permission to delete this event.";

                return RedirectToAction("Overview");
            }

            var acts = _context.EventActs
                .Where(ea => ea.EventId == ev.Id)
                .Include(ea => ea.Event)
                .Select(ea => _context.Acts
                    .SingleOrDefault(a => a.Id == ea.ActId))
                .ToList();

            var model = new EventsDetailsVM()
            {
                Id = ev.Id,
                Name = ev.Name,
                AddressLine = ev.AddressLine,
                PostalCode = ev.PostalCode,
                City = ev.City,
                Start = $"{ev.StartDate.ToShortDateString()} {string.Format("{0:00}:{1:00}", ev.StartTime.Hours, ev.StartTime.Minutes)}",
                End = $"{ev.EndDate.ToShortDateString()} {string.Format("{0:00}:{1:00}", ev.EndTime.Hours, ev.EndTime.Minutes)}",
                Promotor = ev.Promotor?.Email ?? "",
                Acts = acts
            };

            ViewBag.Title = "Delete event";

            return View(model);
        }

        [HttpPost]
        [Route("Events/DeleteEvent/{id}")]
        public async Task<IActionResult> DeleteEvent(Guid id)
        {
            var ev = _context.Events
                .Include(e => e.Promotor)
                .SingleOrDefault(e => e.Id == id);

            if (ev == null)
            {
                TempData["EventNotFound"] = $"Event with id {id} does not exist.";

                return RedirectToAction("Overview");
            }

            if ((await GetCurrentUserAsync()).Id != ev.Promotor.Id)
            {
                TempData["NoPermission"] = $"You have no permission to delete this event.";

                return RedirectToAction("Overview");
            }

            TempData["EventNotDeleted"] = $"Event {ev.Name} could not be deleted.";

            return RedirectToAction("Overview");
        }

        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
