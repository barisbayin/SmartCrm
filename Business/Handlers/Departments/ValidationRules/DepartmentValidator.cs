
using Business.Handlers.Departments.Commands;
using FluentValidation;

namespace Business.Handlers.Departments.ValidationRules
{

	public class CreateDepartmentValidator : AbstractValidator<CreateDepartmentCommand>
	{
		public CreateDepartmentValidator()
		{

		}
	}
	public class UpdateDepartmentValidator : AbstractValidator<UpdateDepartmentCommand>
	{
		public UpdateDepartmentValidator()
		{

		}
	}
}