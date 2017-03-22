﻿using System.Threading.Tasks;
using Abp.Application.Services;
using FirstABP.Roles.Dto;

namespace FirstABP.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
