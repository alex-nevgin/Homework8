namespace NoteBook
{
	public struct Worker
	{
		public string Name { get; set; }
		public string Street { get; set; }
		public string House { get; set; }
		public string Apt { get; set; }
		public string FixNum { get; set; }
		public string CellNum { get; set; }

		public Worker(string name, string street, string house, string apt, string fixNum, string cellNum)
		{
			Name = name;
			Street = street;
			House = house;
			Apt = apt;
			FixNum = fixNum;
			CellNum = cellNum;
		}
	}
}