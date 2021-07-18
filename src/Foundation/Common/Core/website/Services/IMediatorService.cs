using System.ComponentModel.DataAnnotations;
using Camaro.Foundation.Common.Core.Models;

namespace Camaro.Foundation.Common.Core.Services
{
    public interface IMediatorService
    {
        MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel = default(T),
            ValidationResult validationResult = null, object parameters = null, string message = null);
    }
}
