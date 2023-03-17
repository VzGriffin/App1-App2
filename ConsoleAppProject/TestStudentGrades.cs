using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arange Lowest to Highest

            Grades expectedGrade = Grades.F;

            // Sct of getting grade

            Grades actulGrade = converter.ConvertToGrade(0);

            // Assert

            Assert.AreEqual(expectedGrade, actulGrade);
        }
    }
}

