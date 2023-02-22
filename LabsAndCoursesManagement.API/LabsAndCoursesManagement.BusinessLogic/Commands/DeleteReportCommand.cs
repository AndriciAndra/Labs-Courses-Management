using LabsAndCoursesManagement.Models.Helpers;
using LabsAndCoursesManagement.Models.Models;
using MediatR;

namespace LabsAndCoursesManagement.BusinessLogic.Commands
{
    public class DeleteReportCommand : IRequest<Result<Report>>
    {
        public Guid Id { get; set; }
        public DeleteReportCommand(Guid id)
        {
            Id = id;
        }
    }
}
