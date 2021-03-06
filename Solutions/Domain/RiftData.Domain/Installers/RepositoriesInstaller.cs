﻿using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RiftData.Domain.Entities;
using RiftData.Domain.Repositories;

namespace RiftData.Domain.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromThisAssembly()
                                .Pick()
                                .If(IsRepository)
                                .WithService.DefaultInterface()
                                .Configure(x => x.LifeStyle.Is(LifestyleType.Transient)));
        }

        private static bool IsRepository(Type type)
        {
            return type.Name.EndsWith("Repository", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}