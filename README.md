# CodingEventsRichmond

Section 1:  Purpose of this app

This app keeps track of coding type events recorded by the user and saved into a database (of the MySQL type).  
Events have Name, Description, ContactEmal, Id and Category properties.
Category has a Name and Id properties.
With a tag created to crossreference those events with their category (many to many relationship)/

Section 2:  Current state of this app
This app currently tracks events and allows the user to enter more events.

Section 3:  Future improvements that could be made (Person class)
An improvement would be to allow the person to register for an event.  
This person...
*added to the controller as a PersonEventController
*added to the model as Person.cs which would have a name, contactEmail, Id, and Event properties.
*added to the EventDbContext.cs as a DbSet<Person> Person
*added to the ViewModels as AddPersonEventViewModel
*added to the Views as a Person folder then added views to include Index.cshtml, Add.cshtml, Delete.cshtml and Detail.cshtml
*added to the Views/Shared/_layout.cshtml as asp-controller/action methods

after all the coding then complete a migration (add PersonMigration then database update)
through the command terminal to create the table in the MySql database "coding_events"
