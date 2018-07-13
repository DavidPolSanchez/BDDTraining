using System;
using TechTalk.SpecFlow;
using FluentAssertions;


namespace BDDtraining.Behavior.Tests
{
    [Binding]
    public class StudentRepositoryInsertSteps
    {
        protected StudentRepository repository = new StudentRepository();

        protected Student student;

        [Given(@"I have a new  Student whitout id")]
        public void GivenIHaveANewStudentWhitoutId()
        {
            Student student = new Student(new DateTime(1990, 6, 22));
        }
        
        [When(@"I run the method Insert of Student Repository")]
        public void WhenIRunTheMethodInsertOfStudentRepository()
        {
            repository.Insert(student);
        }
        
        [Then(@"the Student Repository should return an Studet with id")]
        public void ThenTheStudentRepositoryShouldReturnAnStudetWithId()
        {
            student.id.Should().Be(1);
            student.Age.Should().Be(1);
        }
    }
}
