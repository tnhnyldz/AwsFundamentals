namespace AwsFundamentals.DynamoDb
{
	public sealed record UpdateCustomerDto(
		Guid Id,
		string Name,
		string Adress);

}
