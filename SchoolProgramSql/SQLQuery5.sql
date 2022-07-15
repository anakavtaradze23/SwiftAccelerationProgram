Select TeacherID 
From TeacherPupil
Where PupilID IN 
	(Select PupilID
	 From Pupil 
	 Where Name='გიორგი'
	 )