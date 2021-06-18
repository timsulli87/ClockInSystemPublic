# ClockInSystemPublic README

This is the public version of my employee timecard system. Feel free to use part or all of my code for your project.

## Notes
* The connection string from the App.config file has been removed.
* The application executes stored procedures in the database. Stored procedures are included in a separate .txt file.
* At the client's request, the "Add Timecard" and "Edit Timecard" functions allow timecards to be created in the future and/or overlap with other timecards.
* "Clock In Store" and the various "Clock In Admin" types were also client requests. They simply mark a timecard with the correct string as its "Type."
