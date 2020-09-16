using System;
using System.Collections.Generic;
using System.Linq;
using BordauxWebApp.Data;
using BordauxLib.Entities;
using BordauxWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BordauxWebApp.Controllers
{
    public class ActsController : Controller
    {
        private readonly BordauxContext _context;

        public ActsController(BordauxContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Overview()
        {
            var model = new List<ActsOverviewVM>();

            var acts = _context.Acts
                .Include(a => a.Events)
                    .ThenInclude(ea => ea.Event)
                .ToList();

            foreach (var act in acts)
            {
                model.Add(new ActsOverviewVM()
                {
                    Id = act.Id,
                    Name = act.Name,
                    Events = act.Events.Where(ea => ea.ActId == act.Id).Select(ea => ea.Event.Name).ToList()
                });
            }

            ViewBag.Title = "Acts overview";

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateAct()
        {
            ViewBag.Title = "Create act";

            return View();
        }

        [HttpPost]
        public IActionResult CreateAct(ActsCreateActVM model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Acts.FirstOrDefault(a => a.Name == model.Name) != null)
                {
                    ModelState.AddModelError("Name", "There is already an act with this name.");

                    return View(model);
                }

                var act = new Act()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name
                };

                _context.Acts.Add(act);
                _context.SaveChanges();

                return RedirectToAction("Overview");
            }

            ViewBag.Title = "Create act";

            return View(model);
        }

        [HttpGet]
        [Route("Acts/UpdateAct/{id}")]
        public IActionResult UpdateAct(Guid id)
        {
            var act = _context.Acts
                .Where(a => a.Id == id)
                .Include(a => a.Events)
                    .ThenInclude(ea => ea.Event)
                .Single();

            var eventsFromAct = act.Events.Select(ea => ea.Event);

            var model = new ActsUpdateActVM()
            {
                Id = act.Id,
                Name = act.Name,
                Events = _context.Events.Select(e => new ActsEventActVM()
                {
                    Name = e.Name,
                    Id = e.Id,
                    IsChecked = eventsFromAct.Contains(e)
                }).ToList()
            };

            ViewBag.Title = "Update act";

            return View(model);
        }

        [HttpPost]
        [Route("Acts/UpdateAct/{id}")]
        public IActionResult UpdateAct(ActsUpdateActVM model)
        {
            var act = _context.Acts
                .Where(a => a.Id == model.Id)
                .Include(a => a.Events)
                    .ThenInclude(ea => ea.Event)
                .Single();

            act.Name = model.Name;

            if (model.Events != null)
            {
                foreach (var ev in model.Events)
                {
                    var e = _context.EventActs.SingleOrDefault(ea => ea.ActId == act.Id && ea.EventId == ev.Id);

                    if (ev.IsChecked)
                    {
                        if (e == null)
                        {
                            _context.EventActs.Add(new EventAct()
                            {
                                Act = act,
                                Event = _context.Events.FirstOrDefault(evt => evt.Id == ev.Id)
                            });
                        }
                    }
                    else
                    {
                        if (e != null)
                        {
                            _context.EventActs.Remove(e);
                        }
                    }
                }
            }

            _context.SaveChanges();

            TempData["ActUpdated"] = $"Act {act.Name} has been updated.";
            ViewBag.Title = "Update act";

            return RedirectToAction("Overview");
        }

        [HttpGet]
        [Route("Acts/ConfirmDeleteAct/{id}")]
        public IActionResult ConfirmDeleteAct(Guid id)
        {
            var act = _context.Acts
                .Where(a => a.Id == id)
                .Include(a => a.Events)
                    .ThenInclude(ea => ea.Event)
                .Single();

            if (act == null)
            {
                TempData["ActNotFound"] = $"Act with id {id} does not exist.";

                return RedirectToAction("Overview", "Acts");
            }

            var model = new ActsOverviewVM()
            {
                Id = act.Id,
                Name = act.Name,
                Events = act.Events.Where(ea => ea.ActId == act.Id).Select(ea => ea.Event.Name).ToList()
            };

            ViewBag.Title = "Delete act";

            return View(model);
        }

        [HttpPost]
        [Route("Acts/DeleteAct/{id}")]
        public IActionResult DeleteAct(Guid id)
        {
            var act = _context.Acts.SingleOrDefault(a => a.Id == id);

            if (act == null)
            {
                TempData["ActNotFound"] = $"Act with id {id} does not exist.";

                return RedirectToAction("Overview", "Acts");
            }

            _context.Acts.Remove(act);
            _context.SaveChanges();

            TempData["ActDeleted"] = $"Act {act.Name} has been removed.";

            return RedirectToAction("Overview");
        }
    }
}