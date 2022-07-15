Create Table Teacher(
	TeacherID int,
	Name varchar(25),
	Surname varchar(25),
	Sex varchar(10),
	Subject varchar(25)
);

Create Table Pupil(
	PupilID int,
	Name varchar(25),
	Surname varchar(25),
	Sex varchar(10),
	Grade varchar(25)
);

Create Table TeacherPupil(
	TeacherID int,
	StudentID int
);