/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
EXEC SP_User_Insert @email = 'user@user.com',
                    @password = 'Test1234=', 
                    @firstname = 'Utilisateur', 
                    @lastname = 'Test';

EXEC SP_Contact_Insert  @iduser = 1,
                        @fname = 'Contact',
                        @lname = 'Test',
                        @tel = '+32477000000',
                        @email = 'contact@contact.com';