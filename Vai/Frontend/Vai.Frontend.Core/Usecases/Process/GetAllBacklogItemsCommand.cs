using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Usecases.Process
{
    public class GetAllBacklogItemsCommand : IGetAllBacklogItemsCommand
    {
        private readonly IApiService apiService;

        public GetAllBacklogItemsCommand(IApiService apiService)
        {
            this.apiService = apiService;
        }
        public Task<CommandResult<GetAllBacklogItemsCommandModel>> Execute(GetAllBacklogItemsCommandParams parameters)
        {
            return apiService.GetAllBacklogItems(parameters.Page, parameters.PageSize);
        }
    }
}
