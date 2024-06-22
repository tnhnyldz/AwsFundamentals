using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AwsFundamentals.DynamoDb.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public sealed class CustomersController : ControllerBase
	{
		#region [ Constructer and fields ]
		private readonly CustomerRepository _customerRepository;

		public CustomersController(CustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}
		#endregion

		[HttpPost]
		public async Task<IActionResult> Create(CreateCustomerDto request)
		{
			await _customerRepository.CreateAsync(request);

			return NoContent();
		}

		[HttpPost]
		public async Task<IActionResult> Update(UpdateCustomerDto request)
		{
			await _customerRepository.UpdateAsync(request);

			return NoContent();
		}

		[HttpGet]
		public async Task<IActionResult> DeleteById(Guid id)
		{
			await _customerRepository.DeleteByIdAsync(id);

			return NoContent();
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			IEnumerable<CustomerDto> customers = await _customerRepository.GetAllAsync();

			return Ok(customers);
		}
	}
}
