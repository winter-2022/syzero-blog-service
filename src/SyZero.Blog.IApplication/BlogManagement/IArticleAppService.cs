﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using SyZero.Application.Attributes;
using SyZero.Application.Routing;
using SyZero.Application.Service.Dto;
using SyZero.Blog.IApplication.BlogManagement.Dto;
using SyZero.Web.Common;

namespace SyZero.Blog.IApplication.Users
{
    public interface IArticleAppService : IApplicationServiceBase
    {
       // Task<PageResultDto<ArticleDto>> GetShowAll(RequestQueryDto input);
    }
}



