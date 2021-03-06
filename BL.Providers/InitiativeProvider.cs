﻿
namespace Hackathon.Providers
{
    using System;
    using Contracts.Initiatives;
    using System.Collections.Generic;
    using Challange = Contracts.Challenge;

    public class InitiativeProvider
    {
        private readonly IInitiativeAdapter _initativeAdapter;

        public InitiativeProvider() { }

        public InitiativeProvider(IInitiativeAdapter initiativeAdapter)
        {
            _initativeAdapter = initiativeAdapter;
        }

        public Initiative Create(InitiativeRequest request)
        {
            var newInitiative = new Initiative
            {
                Id = Guid.NewGuid(),
                Description = request.Description,
                Title = request.Title
            };

            return _initativeAdapter.Create(newInitiative);
        }

        public Initiative Update(Guid id, IInitiativeUpdatable initative)
        {
            return _initativeAdapter.Update(id, initative);
        }

        public Initiative Get(Guid id)
        {
            return _initativeAdapter.Get(id);
        }

        public IEnumerable<Challange.Challenge> GetAllChallenges(Guid initiativeId)
        {
            return _initativeAdapter.GetAllChallenges(initiativeId);
        }

        public IEnumerable<Initiative> GetAllInitiatives()
        {
            return _initativeAdapter.GetAllInitiatives();
        }
    }
}
