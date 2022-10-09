
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Business.Handlers.Departments.ValidationRules;

namespace Business.Handlers.Departments.Commands
{
	/// <summary>
	/// 
	/// </summary>
	public class CreateDepartmentCommand : IRequest<IResult>
	{



		public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, IResult>
		{
			private readonly IDepartmentRepository _departmentRepository;
			private readonly IMediator _mediator;
			public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMediator mediator)
			{
				_departmentRepository = departmentRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(CreateDepartmentValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
			{
				var isThereDepartmentRecord = _departmentRepository.Query().Any(u => u.);

				if (isThereDepartmentRecord == true)
					return new ErrorResult(Messages.NameAlreadyExist);

				var addedDepartment = new Department
				{

				};

				_departmentRepository.Add(addedDepartment);
				await _departmentRepository.SaveChangesAsync();
				return new SuccessResult(Messages.Added);
			}
		}
	}
}