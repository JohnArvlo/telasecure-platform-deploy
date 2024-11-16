﻿using Microsoft.EntityFrameworkCore;
using TelaSecurePlatform.API.Facilities.Domain.Model.Aggregates;
using TelaSecurePlatform.API.Facilities.Domain.Repositories;
using TelaSecurePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TelaSecurePlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace TelaSecurePlatform.API.Facilities.Infrastructure.Persistence.EFC.Repositories;

public class EnvironmentDeviceRepository(AppDbContext context)
: BaseRepository<EnvironmentDevice>(context), IEnvironmentDeviceRepository
{
    public async Task<bool> FindByNameAndStoreRoomIdAsync(string name, string storeRoomId) =>
        await Context.Set<EnvironmentDevice>()
            .AnyAsync(ed => ed.Name == name && ed.StoreRoomId == storeRoomId); 
}