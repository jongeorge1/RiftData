﻿using RiftData.Domain.Entities;
using RiftData.Shared.ViewModels.Dto;

namespace RiftData.ApplicationServices.ViewModelFactories
{
    public interface IDtoFactory
    {
        FishDto Build(Fish fish);
    }
}