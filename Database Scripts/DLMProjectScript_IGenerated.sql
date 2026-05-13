

---- These two databases belong to my teachers.


--restore database DVLD  from disk = 'D:\All Data Bases\DVLD.bak'

--restore database DVLDLast from disk = 'D:\All Data Bases\DVLDLast.bak'

--EXEC sp_changedbowner 'sa';


----==============================================================================================================


Create database MyDLM;
go

use MyDLM;
go

create table [Services_Types]
(
[Service_ID] int primary key identity,
[Service_Name] nvarchar(50) not null,
[Service_Fees] smallmoney not null
);

create table [Orders_Status]
(
[Order_Status_ID] int primary key identity,
[Order_Status_Name] nvarchar(50) not null
);

create table [License_Categories]
(
[License_Category_ID] int primary key identity,
[Category_Name] nvarchar(50) not null,
[Category_Description] nvarchar(500) not null,
[Minimum_Allowed_Age] tinyint not null,
[Fees] smallmoney not null,
[License_Validity_Period] tinyint not null 
);

create table [Tests]
(
[Test_ID] int primary key identity,
[Test_Name] nvarchar(100) not null,
[Test_Fees] smallmoney not null,
[Test_Description] nvarchar(400) not null,
[MaxNumberOfPeople] smallint not null
);

create table [Countries]
(
[Country_ID] int primary key identity,
[Country_Name] nvarchar(50) not null
);

create table [Licenses_Status]
(
[License_Status_ID] int primary key identity,
[Status] nvarchar(50) not null
);

create table [Users]
(
[User_ID] int primary key identity,
[User_Name] nvarchar(50) not null,
[Password] nvarchar(10) not null,
[Is_Active] bit not null
);

create table [People]
(
[Person_ID] int primary key identity,
[First_Name] nvarchar(50) not null,
[Second_Name] nvarchar(50) not null,
[Third_Name] nvarchar(50) not null,
[Last_Name] nvarchar(50) not null,
[Image_Path] nvarchar(200) not null,
[DateOfBirth] date not null,
[Address] nvarchar(200) not null,
[Email] nvarchar(50) null,
[National_Number] nvarchar(14) not null,
[Added_DateTime] smalldatetime not null,
[Gender] nvarchar(7) not null,
[Nationality_Country_ID] int not null foreign key references [Countries] ([Country_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID])
);

alter table [Users] add [Person_ID] int not null foreign key references [People] ([Person_ID]);


create table [Phones]
(
[Phone_ID] int primary key identity,
[Phone_Number] nvarchar(15) not null,
[Person_ID] int not null foreign key references [People] ([Person_ID])
);

create table [Drivers]
(
[Driver_ID] int primary key identity,
[Created_Date] smalldatetime not null,
[Person_ID] int not null foreign key references [People] ([Person_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID])
);

create table [Orders]
(
[Order_ID] int primary key identity,
[Service_Fees] smallmoney not null,
[Last_Status_DateTime] smalldatetime null,
[Added_DateTime] smalldatetime not null,
[Order_Status_ID] int not null foreign key references [Orders_Status] ([Order_Status_ID]),
[Service_ID] int not null foreign key references [Services_Types] ([Service_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID]),
[Person_ID] int not null foreign key references [People] ([Person_ID]) 
);

create table [Licenses]
(
[License_ID] int primary key identity,
[License_Conditions] nvarchar(300) null,
[Image_Path] nvarchar(100) not null,
[Release_Date] date not null,
[End_Date] date not null,
[Is_Active] bit not null,
[License_Fees] smallmoney not null,
[Driver_ID] int not null foreign key references [Drivers] ([Driver_ID]),
[License_Status_ID] int not null foreign key references [Licenses_Status] ([License_Status_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID]),
[Order_ID] int not null foreign key references [Orders] ([Order_ID]),
[License_Category_ID] int not null foreign key references [License_Categories] ([License_Category_ID]),
[Is_Detained] bit not null
);

create table [Release_Licenses_Reservation_Order]
(
[Reservation_ID] int primary key identity,
[Fine] smallmoney not null,
[Reason] nvarchar(200) not null,
[Reservation_Date] smalldatetime not null,
[Payment_Date] smalldatetime null,
[Paid] bit not null,
[Added_DateTime] smalldatetime not null,
[License_ID] int not null foreign key references [Licenses] ([License_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID]),
[ReleasedBy_UserID] int null foreign key references [Users] ([User_ID]),
[Order_ID] int null foreign key references [Orders] ([Order_ID])
);

create table [New_Local_Licenses_Order]
(
[New_Local_License_ID] int primary key identity,
[Order_ID] int not null foreign key references [Orders] ([Order_ID]),
[License_Category_ID] int not null foreign key references [License_Categories] ([License_Category_ID]),
[Passed_Tests] tinyint not null
);

create table [Tests_Appointments]
(
[Appointment_ID] int primary key identity,
[Appointment] smalldatetime not null,
[Is_Completed] bit not null,
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID]),
[Added_DateTime] smalldatetime not null,
[NumberOfPeople] smallint not null
);

create table [Enrollments]
(
[Enrollment_ID] int primary key identity,
[Test_Fees] smallmoney not null,
[Added_DateTime] smalldatetime not null,
[Test_Result] bit null,
[Notes] nvarchar(300) null,
[New_Local_License_ID] int null foreign key references [New_Local_Licenses_Order] ([New_Local_License_ID]),
[Test_ID] int not null foreign key references [Tests] ([Test_ID]),
[Appointment_ID] int not null foreign key references [Tests_Appointments] ([Appointment_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([USer_ID]),
[RetakeTestOrderID] int null foreign key references [Orders] ([Order_ID])
);

create table [International_Licenses]
(
[International_License_ID] int primary key identity,
[Release_Date] date not null,
[End_Date] date not null,
[Is_Active] bit not null,
[Order_ID] int not null foreign key references [Orders] ([Order_ID]),
[Driver_ID] int not null foreign key references [Drivers] ([Driver_ID]),
[CreatedBy_UserID] int not null foreign key references [Users] ([User_ID]),
[Local_License_ID] int not null foreign key references [Licenses] ([License_ID])
);


----==============================================================================================================


---- Constraints


alter table [Orders] add constraint df_OrderAddedDate default GetDate() for [Added_DateTime];
alter table [Licenses] add constraint df_ReleaseDate default GetDate() for [Release_Date];
alter table [People] add constraint df_PersonAddedDate default GetDate() for [Added_DateTime];
alter table [Drivers] add constraint df_DriverAddedDate default GetDate() for [Created_Date];
alter table [Enrollments] add constraint df_EnrollmentAddedDate default GetDate() for [Added_DateTime];
alter table [International_Licenses] add constraint df_International_LicensesAddedDate default GetDate() for [Release_Date];
alter table [Release_Licenses_Reservation_Order] add constraint df_ReservationAddedDate default GetDate() for [Added_DateTime];
alter table [Tests_Appointments] add constraint df_AppointmentAddedDate default GetDate() for [Added_DateTime];

alter table [Tests_Appointments] add constraint ck_Appointment check (Appointment > GetDate()); 

alter table [Users] add constraint unq_User_Name unique ([User_Name]);

alter table [Users] add constraint unq_PersonID unique ([Person_ID]);


----==============================================================================================================

---- Indexes


create unique index ui_OrderID on [New_Local_Licenses_Order] ([Order_ID]);

create index i_NewLocalLicenseID_TestID on [Enrollments] ([New_Local_License_ID], [Test_ID]);
create index i_LocalLicenseApplicationID on [Enrollments] ([New_Local_License_ID]) include ([Test_Result]);
create unique index ui_AppointmentID_NewLocalLicenseID on [Enrollments] ([Appointment_ID], [New_Local_License_ID]) where [New_Local_License_ID] is not null;
create unique index ui_RetakeTestOrderID on [Enrollments] ([RetakeTestOrderID]) include ([Test_Result]) where [RetakeTestOrderID] is not null;

create unique index i_Appointment on [Tests_Appointments] ([Appointment]);

create unique index i_PersonID on [Drivers] ([Person_ID]);

create index ui_DriverID_LicenseCategoryID on [Licenses] ([Driver_ID], [License_Category_ID]);

create index i_LicenseID on [Release_Licenses_Reservation_Order] ([License_ID]) include ([Paid]);

create index i_DriverID on [International_Licenses] ([Driver_ID]) include ([Is_Active]);

create index i_AddedDateTime_ServiceID on [Orders] ([Added_DateTime] ,[Service_ID]);
create index i_ServiceID on [Orders] ([Service_ID]);
create index i_PersonID_ServiceID_OrderStatusID on [Orders] ([Person_ID] ,[Service_ID], [Order_Status_ID]);

Create unique index ui_UserName_Password on [Users] ([User_Name], [Password]);

create unique index ui_Email on [People] ([Email]) where [Email] is not null;
create unique index ui_National_Number on [People] ([National_Number]);


----==============================================================================================================


---- Here, data that is fixed in the system is transferred to my database, which i designed within its dedicated tables,
---- from my teacher's database, instead of being entered manually.
---- this is because the tables containing static data have the same structure and the same data type for each column in both databases,
---- only different table names.


--use DVLDLast;


--insert into MyDLM.dbo.Services_Types select 
--DVLDLast.dbo.ApplicationTypes.ApplicationTypeTitle, DVLDLast.dbo.ApplicationTypes.ApplicationFees from 
--DVLDLast.dbo.ApplicationTypes;


--insert into MyDLM.dbo.Countries select 
--DVLDLast.dbo.Countries.CountryName from 
--DVLDLast.dbo.Countries;


--insert into MyDLM.dbo.License_Categories select 
--DVLDLast.dbo.LicenseClasses.ClassName, DVLDLast.dbo.LicenseClasses.ClassDescription, 
--DVLDLast.dbo.LicenseClasses.MinimumAllowedAge, DVLDLast.dbo.LicenseClasses.ClassFees, 
--DVLDLast.dbo.LicenseClasses.DefaultValidityLength
--from 
--DVLDLast.dbo.LicenseClasses;


--insert into MyDLM.dbo.Tests select 
--DVLDLast.dbo.TestTypes.TestTypeTitle, DVLDLast.dbo.TestTypes.TestTypeFees, DVLDLast.dbo.TestTypes.TestTypeDescription from 
--DVLDLast.dbo.TestTypes;


----==============================================================================================================


---- Insert all static data.



INSERT into [Countries] ( [Country_Name]) VALUES (N'Afghanistan')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Albania')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Algeria')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Andorra')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Angola')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Antigua and Barbuda')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Argentina')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Armenia')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Austria')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Azerbaijan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bahrain')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bangladesh')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Barbados')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Belarus')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Belgium')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Belize')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Benin')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bhutan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bolivia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bosnia and Herzegovina')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Botswana')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Brazil')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Brunei')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Bulgaria')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Burkina Faso')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Burundi')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Cabo Verde')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Cambodia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Cameroon')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Canada')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Central African Republic')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Chad')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Channel Islands')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Chile')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'China')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Colombia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Comoros')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Congo')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Costa Rica')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Côte d''Ivoire')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Croatia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Cuba')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Cyprus')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Czech Republic')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Denmark')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Djibouti')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Dominica')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Dominican Republic')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'DR Congo')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Ecuador')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Egypt')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'El Salvador')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Equatorial Guinea')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Eritrea')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Estonia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Eswatini')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Ethiopia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Faeroe Islands')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Finland')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'France')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'French Guiana')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Gabon')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Gambia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Georgia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Germany')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Ghana')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Gibraltar')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Greece')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Grenada')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Guatemala')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Guinea')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Guinea-Bissau')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Guyana')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Haiti')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Holy See')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Honduras')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Hong Kong')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Hungary')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Iceland')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'India')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Indonesia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Iran')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Iraq')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Ireland')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Isle of Man')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Israel')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Italy')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Jamaica')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Japan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Jordan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Kazakhstan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Kenya')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Kuwait')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Kyrgyzstan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Laos')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Latvia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Lebanon')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Lesotho')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Liberia')
	    
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Libya')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Liechtenstein')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Lithuania')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Luxembourg')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Macao')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Madagascar')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Malawi')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Malaysia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Maldives')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Mali')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Malta')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Mauritania')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Mauritius')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Mayotte')
INSERT into [Countries] ( [Country_Name]) VALUES (N'Mexico')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Moldova')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Monaco')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Mongolia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Montenegro')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Morocco')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Mozambique')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Myanmar')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Namibia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Nepal')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Netherlands')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Nicaragua')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Niger')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Nigeria')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'North Korea')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'North Macedonia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Norway')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Oman')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Pakistan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Panama')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Paraguay')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Peru')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Philippines')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Poland')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Portugal')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Qatar')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Réunion')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Romania')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Russia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Rwanda')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Saint Helena')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Saint Kitts and Nevis')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Saint Lucia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Saint Vincent and the Grenadines')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'San Marino')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Sao Tome & Principe')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Saudi Arabia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Senegal')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Serbia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Seychelles')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Sierra Leone')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Singapore')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Slovakia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Slovenia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Somalia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'South Africa')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'South Korea')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'South Sudan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Spain')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Sri Lanka')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'State of Palestine')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Sudan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Suriname')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Sweden')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Switzerland')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Syria')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Taiwan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Tajikistan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Tanzania')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Thailand')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'The Bahamas')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Timor-Leste')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Togo')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Trinidad and Tobago')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Tunisia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Turkey')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Turkmenistan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Uganda')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Ukraine')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'United Arab Emirates')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'United Kingdom')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'United States')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Uruguay')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Uzbekistan')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Venezuela')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Vietnam')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Western Sahara')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Yemen')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Zambia')
INSERT into [Countries] ( [Country_Name]) VALUES ( N'Zimbabwe')



INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 1 - Small Motorcycle', N'It allows the driver to drive small motorcycles, It is suitable for motorcycles with small capacity and limited power.', 18, 15.0000, 5)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 2 - Heavy Motorcycle License', N'Heavy Motorcycle License (Large Motorcycle License)', 21, 30.0000, 5)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 3 - Ordinary driving license', N'Ordinary driving license (car licence)', 18, 20.0000, 5)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 4 - Commercial', N'Commercial driving license (taxi/limousine)', 21, 200.0000, 10)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 5 - Agricultural', N'Agricultural and work vehicles used in farming or construction, (tractors / tillage machinery)', 21, 50.0000, 10)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 6 - Small and medium bus', N'Small and medium bus license', 21, 250.0000, 10)
INSERT into [License_Categories] ([Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (N'Class 7 - Truck and heavy vehicle', N'Truck and heavy vehicle license', 21, 300.0000, 10)


INSERT into [Licenses_Status] ([Status]) VALUES (N'New')
INSERT into [Licenses_Status] ([Status]) VALUES (N'Lost Replacement')
INSERT into [Licenses_Status] ([Status]) VALUES (N'Damaged Replacement')
INSERT into [Licenses_Status] ([Status]) VALUES (N'Renew')


INSERT into [Orders_Status] ([Order_Status_Name]) VALUES (N'New')
INSERT into [Orders_Status] ([Order_Status_Name]) VALUES (N'Canceled')
INSERT into [Orders_Status] ([Order_Status_Name]) VALUES (N'Complete')


INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'New Local Driving License Service', 15.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'Renew Driving License Service', 7.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'Replacement for a Lost Driving License', 10.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'Replacement for a Damaged Driving License', 5.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'Release Detained Driving Licsense', 15.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'New International License', 51.0000)
INSERT into [Services_Types] ([Service_Name], [Service_Fees]) VALUES (N'Retake Test', 5.0000)


INSERT into [Tests] ([Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (N'Vision Test', 20.0000, N'This assesses the applicant''s visual acuity to ensure they have sufficient vision to drive safely.', 3)
INSERT into [Tests] ([Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (N'Written (Theory) Test', 30.0000, N'This test assesses the applicant''s knowledge of traffic rules, road signs, and driving regulations. It typically consists of multiple-choice questions, and the applicant must select the correct answer(s). The written test aims to ensure that the applicant understands the rules of the road and can apply them in various driving scenarios.', 3)
INSERT into [Tests] ([Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (N'Practical (Street) Test', 40.0000, N'This test evaluates the applicant''s driving skills and ability to operate a motor vehicle safely on public roads. A licensed examiner accompanies the applicant in the vehicle and observes their driving performance.', 3)



----==============================================================================================================


---- Displaying the tables containing the static data after the transfer process


--select * from MyDLM.dbo.Services_Types;
--select * from [ApplicationTypes];

--select * from MyDLM.dbo.Countries;
--select * from [Countries];

--select * from MyDLM.dbo.License_Categories;
--select * from [LicenseClasses];

--select * from MyDLM.dbo.Tests;
--select * from [TestTypes];


--select * from MyDLM.dbo.[International_Licenses];


----==============================================================================================================


---- Here we will implement some code so that I can add an admin to the program so that we can access it.


-- use MyDLM;

--select * from [Countries] where [Country_Name] = 'Egypt';

 alter table [People] alter column [CreatedBy_UserID] int null;
 go

insert into [People] values 
('Ebarhim', 'Hasan', 'Ebrahim', 'Ebrahim',
'D:\Visual Studio 2022 Projects\DLMApp_WindowsForms\People Images\Guid23029eb5-8b97-4b23-99f4-7e511482cc1f.jpg', '07-07-1998',
'Elmansoura Elgalaa Steet 25', 'ebrahim.hasan.dev@gmail.com', '12345678902478', GETDATE(), 'Male', 51, null);
go

--select * from [People];

insert into [Users] values ('admin', '123', 1, 1);
go

update [People] set [CreatedBy_UserID] = 1;
go


--select * from [Users];

---- Here, column [CreatedBy_UserID] in table [People] has been modified so that it no longer accepts null values
---- by using the following line of code

 alter table [People] alter column [CreatedBy_UserID] int not null;
 go

create index i_PersonID on [Phones] ([Person_ID]);

go

alter table [Phones] add constraint unq_PhoneNumber unique ([Phone_Number]);
go

insert into [Phones] values ('01001978166', 1);
go

--select * from [Phones];


----==============================================================================================================

---- Views 

create view vPeopleRegisteredInAppointment as
select [Orders].[Order_ID], [People].[Person_ID], [First_Name], [Second_Name], [Third_Name], [Last_Name],
[National_Number], [Test_Result], [Appointment], [NumberOfPeople],
[Is_Completed], [Tests].[Test_ID], [Tests_Appointments].[Appointment_ID], [Users].[User_Name] as AppointmentCreatedByUserName,
[Enrollments].[New_Local_License_ID] ,[Enrollments].[Notes], [License_Category_ID]
from 
[Enrollments] join [Tests] on [Enrollments].[Test_ID] = [Tests].[Test_ID]
join [Tests_Appointments] on [Enrollments].[Appointment_ID] = [Tests_Appointments].[Appointment_ID]
join [New_Local_Licenses_Order] on [Enrollments].[New_Local_License_ID] = [New_Local_Licenses_Order].[New_Local_License_ID]
join [Orders] on [New_Local_Licenses_Order].[Order_ID] = [Orders].[Order_ID]
join [People] on [Orders].[Person_ID] = [People].[Person_ID]
join [Countries] on [People].[Nationality_Country_ID] = [Countries].[Country_ID]
join [Users] on [Tests_Appointments].[CreatedBy_UserID] = [Users].[User_ID];

go
--select * from [vPeopleRegisteredInAppointment] where Test_ID = 1 and Is_Completed = 0;

----=====================================

create view vPeopleRegisteredInAppointmentRenewLicense as
select [Orders].[Order_ID], [People].[Person_ID], [First_Name], [Second_Name], [Third_Name], [Last_Name],
[National_Number], [Test_Result], [Appointment], [NumberOfPeople],
[Is_Completed], [Tests].[Test_ID], [Tests_Appointments].[Appointment_ID], [Users].[User_Name] as AppointmentCreatedByUserName,
[Enrollments].[New_Local_License_ID], [Enrollments].[Notes]
from 
[Enrollments] join [Tests] on [Enrollments].[Test_ID] = [Tests].[Test_ID]
join [Tests_Appointments] on [Enrollments].[Appointment_ID] = [Tests_Appointments].[Appointment_ID]
join [Orders] on [Enrollments].[RetakeTestOrderID] = [Orders].[Order_ID]
join [People] on [Orders].[Person_ID] = [People].[Person_ID]
join [Countries] on [People].[Nationality_Country_ID] = [Countries].[Country_ID]
join [Users] on [Tests_Appointments].[CreatedBy_UserID] = [Users].[User_ID] where [New_Local_License_ID] is null;

go

--select * from [vPeopleRegisteredInAppointmentRenewLicense] where Test_ID = 1 and Is_Completed = 0;

----=====================================

create view vGetLicenseClassInfoByApplicationID as
select [License_Categories].*, [Orders].[Order_ID], [Orders].[Person_ID], [Orders].[Order_Status_ID]
from [Orders] join [New_Local_Licenses_Order]
on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID]
join [License_Categories] 
on [New_Local_Licenses_Order].[License_Category_ID] = [License_Categories].[License_Category_ID];

go

--select * from [vGetLicenseClassInfoByApplicationID] where [Order_ID] = 40;

----=====================================

create view vDoesHaveLicenseOfSameClass as
select [People].[Person_ID], [Licenses].* 
from [People] join [Drivers] on [People].[Person_ID] = [Drivers].[Person_ID]
join [Licenses] on [Drivers].[Driver_ID] = [Licenses].[Driver_ID];

go

--select * from [vDoesHaveLicenseOfSameClass] where [Person_ID] = 61 and [License_Category_ID] = 3;

----=====================================

create view [vFindPersonByLicenseID] as
select [People].*, [License_ID], [User_Name] from 
[Licenses] join [Drivers] on [Licenses].[Driver_ID] = [Drivers].[Driver_ID]
join [People] on [Drivers].[Person_ID] = [People].[Person_ID]
join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID];

go

--select * from [vFindPersonByLicenseID] where [License_ID] = 1;

----=====================================

create view [vLicensesInfo] as
select [People].[Person_ID], [People].[National_Number], [Licenses].*, [Category_Name], [Users].[User_Name]
from [Licenses] join [Drivers] on [Licenses].[Driver_ID] = [Drivers].[Driver_ID]
join [People] on [Drivers].[Person_ID] = [People].[Person_ID]
join [Licenses_Status] on [Licenses].[License_Status_ID] = [Licenses_Status].[License_Status_ID]
join [License_Categories] on [Licenses].[License_Category_ID] = [License_Categories].[License_Category_ID]
join [Users] on [Licenses].[CreatedBy_UserID] = [Users].[User_ID];

go

--select * from [vLicensesInfo];

----=====================================

create view [vNewLocalLicensesOrders] as
select [Orders].*, [User_Name], [Passed_Tests], [License_Category_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [New_Local_Licenses_Order] on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID];

go

--select * from [vNewLocalLicensesOrders];

----=====================================

create view [vRenewLicensesOrders] as
select [Orders].*, [User_Name], [Test_Result], [Enrollment_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
left join [Enrollments] on [Orders].[Order_ID] = [Enrollments].[RetakeTestOrderID];

go

--select * from [vRenewLicensesOrders];

----=====================================

create view [vNewLocalLicensesOrdersForNationalNumber] as
select [Orders].*, [User_Name], [Passed_Tests], [National_number], [License_Category_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [People] on [People].[Person_ID] = [Orders].[Person_ID]
join [New_Local_Licenses_Order] on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID];

go

--select * from [vNewLocalLicensesOrdersForNationalNumber];

----=====================================

create view [vRenewLicensesOrdersForNationalNumber] as
select [Orders].*, [User_Name], [Test_Result], [Enrollment_ID], [National_number]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [People] on [People].[Person_ID] = [Orders].[Person_ID]
left join [Enrollments] on [Orders].[Order_ID] = [Enrollments].[RetakeTestOrderID];

go

--select * from [vRenewLicensesOrdersForNationalNumber];

----==============================================================================================================


--select * from [Orders_Status];
--select * from [Licenses_Status];
--select * from [Services_Types];
--select * from [Tests];
--select * from [License_Categories];

--select * from [People];
--select * from [Phones];
--select * from [Users];

--select * from [New_Local_Licenses_Order];
--select * from [Enrollments];
--select * from [Orders];
--select * from [Tests_Appointments];

--select * from [Drivers];
--select * from [Licenses];
--select * from [Release_Licenses_Reservation_Order];
--select * from [International_Licenses];


--delete [Enrollments];
--delete [New_Local_Licenses_Order];
--delete [Orders];
--delete [Tests_Appointments];
--delete [Licenses];
--delete [Drivers];
--delete [International_Licenses];
--delete [Release_Licenses_Reservation_Order];

----=====================================================

--delete [Users] where [Person_ID] != 1;

--delete [Phones] where [Person_ID] != 1;
--delete [People] where [Person_ID] != 1;

----=====================================================
