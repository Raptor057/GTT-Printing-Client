//using MediatR;
//using System.Threading;
//using System.Threading.Tasks;

//namespace GT.Trace.Labels.Templates.UseCases.PrintKitSavLabel
//{
//    internal class PrintKitSavLabelHandler : IRequestHandler<PrintKitSavLabelRequest>
//    {
//        public Task<Unit> Handle(PrintKitSavLabelRequest request, CancellationToken cancellationToken)
//        {
//            using (KitSavLabel label = new KitSavLabel(
//                request.CustomerPartNo, 
//                request.PartNo, 
//                request.PartDescription,
//                request.WWW))
//            {
//                label.CreateAndPrintDocument(request);
//            }
//            return Unit.Task;
//        }
//    }
//}
