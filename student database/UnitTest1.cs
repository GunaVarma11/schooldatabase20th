using Moq;

namespace student_database
{
   [TestFixture]
    public class Tests
    {
        ClassLibrary1.Management mg;
        [SetUp]
        public void Setup()
        {
            mg = new ClassLibrary1.Management();
        }

        [Test]
        public void AllStuNotNull()
        {
            foreach(ClassLibrary1.School_database_1 sc in  mg.Allstulist()) {
                Assert.IsNotNull(sc.StudentId);
                Assert.IsNotNull(sc.StudentName);
                Assert.IsNotNull(sc.TeacherName);
                Assert.IsNotNull(sc.SubjectName);
            }

        }
        [Test]
        public void SearchStuTest()
        {
            int id = 2;
            string name = "Shyam";
            foreach(ClassLibrary1.School_database_1 sc in mg.SearchStu(2))
            {
                Assert.That(sc.StudentId, Is.EqualTo(id));
                Assert.That(sc.StudentName, Is.EqualTo(name));
            }
        }
        [Test]
        public void StumarkTest()
        {
            Mock<ClassLibrary1.Management> mock = new Mock<ClassLibrary1.Management>();
            mock.Setup(x => x.StudentMarks()).Returns(true);
            Assert.That(mock.Object.StudentMarks(), Is.EqualTo(true));
        }
    }
}