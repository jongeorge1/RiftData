﻿using RiftData.Domain.Entities;

namespace RiftData.Domain.Factories
{
    public class FishFactory : IFishFactory
    {
        public Fish Build(int id, Species species, Locale locale, bool hasPhoto)
        {
            return new Fish(id)
                    {
                           Genus = species.Genus,
                           Species = species,
                           Locale = locale,
                           HasPhotos = hasPhoto
                    };
        }
    }
}