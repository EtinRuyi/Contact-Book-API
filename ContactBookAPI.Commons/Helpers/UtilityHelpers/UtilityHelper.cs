using ContactBookAPI.Model.Entities.Shared;
using System.Web.Mvc;

namespace ContactBookAPI.Commons.Helpers.UtilityHelpers
{
    public static class UtilityHelper
    {
        public static BaseResponse<T> BuildResponse<T>(string message,
                                                       int responseCode,
                                                       T Data,
                                                       ModelStateDictionary error,
                                                       bool IsSuccessful)
        {
            var errors = new List<ErrorItem>();
            if (error != null)
            {
                foreach (var errorItem in error)
                {
                    var key = errorItem.Key;
                    var value = errorItem.Value;
                    var errorListMessage = new List<string>();
                    foreach (var item in value.Errors)
                    {
                        errorListMessage.Add(item.ErrorMessage);
                    }

                    errors.Add(new ErrorItem { Key = errorItem.Key, ErrorMessages = errorListMessage });
                }
            }
            return new BaseResponse<T>
            {
                Message = message,
                IsSuccessful = IsSuccessful,
                ResponseCode = responseCode,
                Data = Data,
                Errors = errors
            };
        }
    }
}
