
using Business.Constants;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Core.Aspects.Autofac.Validation;
using Business.Handlers.Departments.ValidationRules;


namespace Business.Handlers.Departments.Commands
{


	public class UpdateDepartmentCommand : IRequest<IResult>
	{
		public string DepartmentName { get; set; }

		public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, IResult>
		{
			private readonly IDepartmentRepository _departmentRepository;
			private readonly IMediator _mediator;

			public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMediator mediator)
			{
				_departmentRepository = departmentRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(UpdateDepartmentValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
			{
				var isThereDepartmentRecord = await _departmentRepository.GetAsync(u => u.DepartmentName == request.DepartmentName);




				_departmentRepository.Update(isThereDepartmentRecord);
				await _departmentRepository.SaveChangesAsync();
				return new SuccessResult(Messages.Updated);
			}
		}
	}
}

