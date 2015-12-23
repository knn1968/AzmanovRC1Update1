using AutoMapper;
using Azmanov.Data;
using Azmanov.Entities;
using Azmanov.ViewModels.Paging;
using Core;
using Core.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azmanov.Factories
{
    public class EventUpdateViewModelFactory : IModelFactory<Event, EventUpdateViewModel>
    {
        private AzmanovContext _context;

        public EventUpdateViewModelFactory(AzmanovContext context)
        {
            _context = context;
        }
        public EventUpdateViewModel CreateInstance(Event input)
        {
            return CreateInstance(input, _context.Languages.Single(p => p.Default).ShortDisplay);
        }

        public EventUpdateViewModel CreateInstance(Event input, string languageShortDisplay)
        {
            var language = _context.Languages.First(p => p.ShortDisplay == languageShortDisplay);

            return Mapper.Map<EventUpdateViewModel>(input);
        }

        public IEnumerable<EventUpdateViewModel> CreateList(IEnumerable<Event> input)
        {
            return CreateList(input, _context.Languages.Single(p => p.Default).ShortDisplay);
        }

        public IEnumerable<EventUpdateViewModel> CreateList(IEnumerable<Event> input, string languageShortDisplay)
        {
            var language = _context.Languages.First(p => p.ShortDisplay == languageShortDisplay);

            var v = Mapper.Map<IEnumerable<EventUpdateViewModel>>(input);

            return v;
        }
    }
}
