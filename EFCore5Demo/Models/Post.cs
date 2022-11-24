namespace EFCore5Demo.Models
{
	public class Post
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public Blog Blog { get; set; }
	}
}