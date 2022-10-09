
using Business.Handlers.Departments.Commands;
using Business.Handlers.Departments.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Entities.Concrete;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Departments If controller methods will not be Authorize, [AllowAnonymous] is used.
	/// </summary>
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentsController : BaseApiController
	{
		///<summary>
		///List Departments
		///</summary>
		///<remarks>Departments</remarks>
		///<return>List Departments</return>
		///<response code="200"></response>
		[Produces("application/json", "text/plain")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Department>))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpGet("getall")]
		public async Task<IActionResult> GetList()
		{
			var result = await Mediator.Send(new GetDepartmentsQuery());
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		///<summary>
		///It brings the details according to its id.
		///</summary>
		///<remarks>Departments</remarks>
		///<return>Departments List</return>
		///<response code="200"></response>  
		[Produces("application/json", "text/plain")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Department))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpGet("getbyid")]
		public async Task<IActionResult> GetById(int departmentName)
		{
			var result = await Mediator.Send(new GetDepartmentQuery { DepartmentName = departmentName });
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		/// <summary>
		/// Add Department.
		/// </summary>
		/// <param name="createDepartment"></param>
		/// <returns></returns>
		[Produces("application/json", "text/plain")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreateDepartmentCommand createDepartment)
		{
			var result = await Mediator.Send(createDepartment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		/// <summary>
		/// Update Department.
		/// </summary>
		/// <param name="updateDepartment"></param>
		/// <returns></returns>
		[Produces("application/json", "text/plain")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpPut]
		public async Task<IActionResult> Update([FromBody] UpdateDepartmentCommand updateDepartment)
		{
			var result = await Mediator.Send(updateDepartment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		/// <summary>
		/// Delete Department.
		/// </summary>
		/// <param name="deleteDepartment"></param>
		/// <returns></returns>
		[Produces("application/json", "text/plain")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpDelete]
		public async Task<IActionResult> Delete([FromBody] DeleteDepartmentCommand deleteDepartment)
		{
			var result = await Mediator.Send(deleteDepartment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
