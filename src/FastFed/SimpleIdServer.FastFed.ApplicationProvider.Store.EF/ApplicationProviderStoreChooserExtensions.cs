﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleIdServer.FastFed.ApplicationProvider.Models;
using SimpleIdServer.FastFed.ApplicationProvider.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleIdServer.FastFed.ApplicationProvider.Store.EF;

public static class ApplicationProviderStoreChooserExtensions
{
    public static void UseEfStore(this ApplicationProviderStoreChooser chooser, Action<DbContextOptionsBuilder> dbCallback = null)
    {
        if (dbCallback != null) chooser.Services.AddDbContext<FastFedDbContext>(dbCallback);
        else chooser.Services.AddDbContext<FastFedDbContext>(o => o.UseInMemoryDatabase("webfinger"));
        chooser.Services.AddTransient<IIdentityProviderFederationStore, IdentityProviderFederationStore>();
    }

    public static void UseInMemoryEfStore(this ApplicationProviderStoreChooser chooser, params IdentityProviderFederation[] identityProviderFederations)
        => UseInMemoryEfStore(chooser, identityProviderFederations.ToList());

    public static void UseInMemoryEfStore(this ApplicationProviderStoreChooser chooser, List<IdentityProviderFederation> identityProviderFederations)
    {
        UseEfStore(chooser);
        using (var sp = chooser.Services.BuildServiceProvider())
        {
            using (var scope = sp.CreateScope())
            {
                using (var dbContext = scope.ServiceProvider.GetService<FastFedDbContext>())
                {
                    dbContext.IdentityProviderFederations.AddRange(identityProviderFederations);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
