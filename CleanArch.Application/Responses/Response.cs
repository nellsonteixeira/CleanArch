using System.Collections.ObjectModel;

namespace CleanArch.Application.Responses
{
    public class Response
    {
        private readonly IList<string> _messages = new List<string>();

        public IEnumerable<string> Errors { get; }
        public object Result { get; }

        /// <summary>
        /// Represent a response to a request
        /// </summary>
        public Response()
        {
            Errors = new ReadOnlyCollection<string>(_messages);
        }

        /// <summary>
        /// Create a response to a request
        /// </summary>
        /// <param name="result">Return Object</param>
        public Response(object result)
            : this()
        {
            Result = result;
        }

        /// <summary>
        /// Add a error menssage to response
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Response AddError(string message)
        {
            _messages.Add(message);
            return this;
        }
    }
}
