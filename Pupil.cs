using System;

public class Pupil
{
	[Key]
	public int PupilId { get; set; }

	[Required]
	public string Name { get; set; }

	[Rquired]
	public string Surname { get; set; }

	[Required]
	public string Sex { get; set; }

	[Required]
	public string Grade { get; set; }

	public List<Teacher> Teacher { get; set; }
}
