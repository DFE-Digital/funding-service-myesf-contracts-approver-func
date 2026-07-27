using System.Net.Http;
using System.Threading.Tasks;

namespace Pds.Contracts.Approver.Services.Tests.Unit.Dummy
{
    internal interface IDummyService
    {
        Task<HttpResponseMessage> MakeHttpCallAsync();
    }
}
