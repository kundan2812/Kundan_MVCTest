**Export Report**

[Report1.txt](https://github.com/user-attachments/files/20350326/Report1.txt)


**Query**
CREATE TABLE [dbo].[UserMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[EmailId] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(

**Insert**
 Insert into UserMaster (FirstName,MiddleName,LastName,EmailId,UserName,BirthDate)
 VALUES
 ('Rahul','Kumar','Singh','rahul.singh@example.com','rahuls','1995-04-12'),
  ('Anjali','Mehta','Sharma','anjali.sharma@example.com','anjaliMehta','1993-11-30'),
  ('Vikram',Null,'Patel','vikram.patel@example.com','vikramp','1990-07-25'),
  ('Priya','Rani','Verma','priya.verma@example.com','priyav','1992-01-05');
