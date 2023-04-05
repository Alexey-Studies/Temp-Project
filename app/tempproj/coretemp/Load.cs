namespace tempproj.coretemp
{
    internal class Load : SubjectData
    {

        enum TypesOfClasses //ВИДЫ ЗАНЯТИЙ															
        {
            Lectures = 0,
            PracticalExercises = 1,
            LaboratoryWork = 2,
            Seminars = 3,
            CourseConsultations = 4,
            ManagementOfDiplomaDesign = 5,
            CourseProjectWork = 6,
            Credits = 7,
            Exams = 8,
            ManagementOfGraduateStudents = 9,
            ManagementOfProductionPractice = 10,
            ManagementOfEducationalPractice = 11,
            CheckingTheWorOfPartTimeStudents = 12,
            GEK = 13,
            MRK = 14,
            Total = 15
        }
        public void Processing(int type)  //обработка
        {
            switch (type)
            {
                case 0:

                    break;
                case 15:
                //я не понимаю как работает это

                default:
                    break;

            }
        }



    }
}

