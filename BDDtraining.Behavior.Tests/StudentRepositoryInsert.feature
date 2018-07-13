Feature: StudentRepositoryInsert
	Insert Student in Student Repository

@adding
Scenario: Adding an Student
	Given I have a new  Student whitout id
	When I run the method Insert of Student Repository
	Then the Student Repository should return an Studet with id
