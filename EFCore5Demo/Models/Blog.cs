using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore5Demo.Models
{
	public class Blog
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public List<Post> Posts { get; set; }
	}
}
