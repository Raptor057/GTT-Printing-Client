using MediatR;

namespace GT.Trace.Labels.App.UseCases.Persistence.SaveLineCode
{
    public sealed class SaveLineCodeRequest : IRequest<SaveLineCodeResponse>
    {
        public SaveLineCodeRequest(string lineCode)
        {
            LineCode = lineCode;
        }

        public string LineCode { get; set; }
    }
}