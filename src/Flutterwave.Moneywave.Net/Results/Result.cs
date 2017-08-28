using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Results
{
    public class Result
    {
        private List<string> _errors;
        public List<string> _sucesssMessages;
        public bool IsSuccess()
        {
            return !_errors.Any(); // Should be more
        }

        public bool IsFailure()
        {
            return _errors.Any();
        }

        public List<string> Errors()
        {
            return _errors;
        }

        public void AddError(params string[] errors)
        {
            _errors.AddRange(errors);
        }

        public void AddSuccess(params string[] success)
        {
            _sucesssMessages.AddRange(success);
        }

        public List<string> Messages()
        {
            var result = _sucesssMessages;
            result.AddRange(_errors);
            return new List<string>(result);
        }
    }

}
