namespace AwsFundamentals.DynamoDb
{
	public sealed class Customer
	{
		public Customer()
		{
			Id = Guid.NewGuid();
		}
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
	}
}
