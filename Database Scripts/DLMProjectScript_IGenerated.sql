

---- These two databases belong to my teachers.


--restore database DVLD  from disk = 'D:\All Data Bases\DVLD.bak'

--restore database DVLDLast from disk = 'D:\All Data Bases\DVLDLast.bak'

--EXEC sp_changedbowner 'sa';


----==============================================================================================================


Create database MyDLM;

use MyDLM;


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


SET IDENTITY_INSERT [dbo].[Countries] ON 
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (1, N'Afghanistan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (2, N'Albania')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (3, N'Algeria')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (4, N'Andorra')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (5, N'Angola')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (6, N'Antigua and Barbuda')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (7, N'Argentina')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (8, N'Armenia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (9, N'Austria')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (10, N'Azerbaijan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (11, N'Bahrain')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (12, N'Bangladesh')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (13, N'Barbados')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (14, N'Belarus')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (15, N'Belgium')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (16, N'Belize')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (17, N'Benin')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (18, N'Bhutan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (19, N'Bolivia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (20, N'Bosnia and Herzegovina')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (21, N'Botswana')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (22, N'Brazil')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (23, N'Brunei')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (24, N'Bulgaria')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (25, N'Burkina Faso')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (26, N'Burundi')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (27, N'Cabo Verde')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (28, N'Cambodia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (29, N'Cameroon')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (30, N'Canada')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (31, N'Central African Republic')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (32, N'Chad')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (33, N'Channel Islands')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (34, N'Chile')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (35, N'China')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (36, N'Colombia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (37, N'Comoros')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (38, N'Congo')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (39, N'Costa Rica')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (40, N'Côte d''Ivoire')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (41, N'Croatia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (42, N'Cuba')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (43, N'Cyprus')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (44, N'Czech Republic')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (45, N'Denmark')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (46, N'Djibouti')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (47, N'Dominica')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (48, N'Dominican Republic')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (49, N'DR Congo')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (50, N'Ecuador')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (51, N'Egypt')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (52, N'El Salvador')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (53, N'Equatorial Guinea')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (54, N'Eritrea')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (55, N'Estonia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (56, N'Eswatini')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (57, N'Ethiopia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (58, N'Faeroe Islands')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (59, N'Finland')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (60, N'France')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (61, N'French Guiana')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (62, N'Gabon')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (63, N'Gambia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (64, N'Georgia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (65, N'Germany')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (66, N'Ghana')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (67, N'Gibraltar')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (68, N'Greece')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (69, N'Grenada')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (70, N'Guatemala')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (71, N'Guinea')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (72, N'Guinea-Bissau')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (73, N'Guyana')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (74, N'Haiti')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (75, N'Holy See')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (76, N'Honduras')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (77, N'Hong Kong')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (78, N'Hungary')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (79, N'Iceland')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (80, N'India')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (81, N'Indonesia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (82, N'Iran')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (83, N'Iraq')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (84, N'Ireland')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (85, N'Isle of Man')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (86, N'Israel')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (87, N'Italy')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (88, N'Jamaica')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (89, N'Japan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (90, N'Jordan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (91, N'Kazakhstan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (92, N'Kenya')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (93, N'Kuwait')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (94, N'Kyrgyzstan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (95, N'Laos')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (96, N'Latvia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (97, N'Lebanon')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (98, N'Lesotho')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (99, N'Liberia')
GO
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (100, N'Libya')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (101, N'Liechtenstein')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (102, N'Lithuania')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (103, N'Luxembourg')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (104, N'Macao')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (105, N'Madagascar')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (106, N'Malawi')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (107, N'Malaysia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (108, N'Maldives')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (109, N'Mali')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (110, N'Malta')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (111, N'Mauritania')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (112, N'Mauritius')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (113, N'Mayotte')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (114, N'Mexico')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (115, N'Moldova')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (116, N'Monaco')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (117, N'Mongolia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (118, N'Montenegro')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (119, N'Morocco')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (120, N'Mozambique')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (121, N'Myanmar')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (122, N'Namibia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (123, N'Nepal')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (124, N'Netherlands')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (125, N'Nicaragua')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (126, N'Niger')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (127, N'Nigeria')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (128, N'North Korea')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (129, N'North Macedonia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (130, N'Norway')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (131, N'Oman')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (132, N'Pakistan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (133, N'Panama')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (134, N'Paraguay')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (135, N'Peru')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (136, N'Philippines')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (137, N'Poland')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (138, N'Portugal')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (139, N'Qatar')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (140, N'Réunion')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (141, N'Romania')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (142, N'Russia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (143, N'Rwanda')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (144, N'Saint Helena')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (145, N'Saint Kitts and Nevis')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (146, N'Saint Lucia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (147, N'Saint Vincent and the Grenadines')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (148, N'San Marino')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (149, N'Sao Tome & Principe')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (150, N'Saudi Arabia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (151, N'Senegal')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (152, N'Serbia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (153, N'Seychelles')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (154, N'Sierra Leone')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (155, N'Singapore')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (156, N'Slovakia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (157, N'Slovenia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (158, N'Somalia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (159, N'South Africa')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (160, N'South Korea')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (161, N'South Sudan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (162, N'Spain')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (163, N'Sri Lanka')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (164, N'State of Palestine')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (165, N'Sudan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (166, N'Suriname')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (167, N'Sweden')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (168, N'Switzerland')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (169, N'Syria')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (170, N'Taiwan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (171, N'Tajikistan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (172, N'Tanzania')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (173, N'Thailand')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (174, N'The Bahamas')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (175, N'Timor-Leste')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (176, N'Togo')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (177, N'Trinidad and Tobago')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (178, N'Tunisia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (179, N'Turkey')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (180, N'Turkmenistan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (181, N'Uganda')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (182, N'Ukraine')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (183, N'United Arab Emirates')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (184, N'United Kingdom')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (185, N'United States')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (186, N'Uruguay')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (187, N'Uzbekistan')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (188, N'Venezuela')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (189, N'Vietnam')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (190, N'Western Sahara')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (191, N'Yemen')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (192, N'Zambia')
INSERT [dbo].[Countries] ([Country_ID], [Country_Name]) VALUES (193, N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO

SET IDENTITY_INSERT [dbo].[License_Categories] ON 

INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (1, N'Class 1 - Small Motorcycle', N'It allows the driver to drive small motorcycles, It is suitable for motorcycles with small capacity and limited power.', 18, 15.0000, 5)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (2, N'Class 2 - Heavy Motorcycle License', N'Heavy Motorcycle License (Large Motorcycle License)', 21, 30.0000, 5)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (3, N'Class 3 - Ordinary driving license', N'Ordinary driving license (car licence)', 18, 20.0000, 5)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (4, N'Class 4 - Commercial', N'Commercial driving license (taxi/limousine)', 21, 200.0000, 10)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (5, N'Class 5 - Agricultural', N'Agricultural and work vehicles used in farming or construction, (tractors / tillage machinery)', 21, 50.0000, 10)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (6, N'Class 6 - Small and medium bus', N'Small and medium bus license', 21, 250.0000, 10)
INSERT [dbo].[License_Categories] ([License_Category_ID], [Category_Name], [Category_Description], [Minimum_Allowed_Age], [Fees], [License_Validity_Period]) VALUES (7, N'Class 7 - Truck and heavy vehicle', N'Truck and heavy vehicle license', 21, 300.0000, 10)
SET IDENTITY_INSERT [dbo].[License_Categories] OFF
GO

SET IDENTITY_INSERT [dbo].[Licenses_Status] ON 

INSERT [dbo].[Licenses_Status] ([License_Status_ID], [Status]) VALUES (1, N'New')
INSERT [dbo].[Licenses_Status] ([License_Status_ID], [Status]) VALUES (2, N'Lost Replacement')
INSERT [dbo].[Licenses_Status] ([License_Status_ID], [Status]) VALUES (3, N'Damaged Replacement')
INSERT [dbo].[Licenses_Status] ([License_Status_ID], [Status]) VALUES (4, N'Renew')
SET IDENTITY_INSERT [dbo].[Licenses_Status] OFF
GO

SET IDENTITY_INSERT [dbo].[Orders_Status] ON 

INSERT [dbo].[Orders_Status] ([Order_Status_ID], [Order_Status_Name]) VALUES (1, N'New')
INSERT [dbo].[Orders_Status] ([Order_Status_ID], [Order_Status_Name]) VALUES (2, N'Canceled')
INSERT [dbo].[Orders_Status] ([Order_Status_ID], [Order_Status_Name]) VALUES (3, N'Complete')
SET IDENTITY_INSERT [dbo].[Orders_Status] OFF
GO

SET IDENTITY_INSERT [dbo].[Services_Types] ON 

INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (1, N'New Local Driving License Service', 15.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (2, N'Renew Driving License Service', 7.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (3, N'Replacement for a Lost Driving License', 10.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (4, N'Replacement for a Damaged Driving License', 5.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (5, N'Release Detained Driving Licsense', 15.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (6, N'New International License', 51.0000)
INSERT [dbo].[Services_Types] ([Service_ID], [Service_Name], [Service_Fees]) VALUES (7, N'Retake Test', 5.0000)
SET IDENTITY_INSERT [dbo].[Services_Types] OFF
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([Test_ID], [Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (1, N'Vision Test', 20.0000, N'This assesses the applicant''s visual acuity to ensure they have sufficient vision to drive safely.', 3)
INSERT [dbo].[Tests] ([Test_ID], [Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (2, N'Written (Theory) Test', 30.0000, N'This test assesses the applicant''s knowledge of traffic rules, road signs, and driving regulations. It typically consists of multiple-choice questions, and the applicant must select the correct answer(s). The written test aims to ensure that the applicant understands the rules of the road and can apply them in various driving scenarios.', 3)
INSERT [dbo].[Tests] ([Test_ID], [Test_Name], [Test_Fees], [Test_Description], [MaxNumberOfPeople]) VALUES (3, N'Practical (Street) Test', 40.0000, N'This test evaluates the applicant''s driving skills and ability to operate a motor vehicle safely on public roads. A licensed examiner accompanies the applicant in the vehicle and observes their driving performance.', 3)
SET IDENTITY_INSERT [dbo].[Tests] OFF
GO


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


use MyDLM;

--select * from [Countries] where [Country_Name] = 'Egypt';

 alter table [People] alter column [CreatedBy_UserID] int null;

insert into [People] values 
('Ebarhim', 'Hasan', 'Ebrahim', 'Ebrahim',
'D:\Visual Studio 2022 Projects\DLMApp_WindowsForms\People Images\Guid23029eb5-8b97-4b23-99f4-7e511482cc1f.jpg', '07-07-1998',
'Elmansoura Elgalaa Steet 25', 'ebrahim.hasan.dev@gmail.com', '12345678902478', GETDATE(), 'Male', 51, null);


--select * from [People];

update [People] set [CreatedBy_UserID] = 1;

insert into [Users] values ('admin', '123', 1, 1);

--select * from [Users];

---- Here, column [CreatedBy_UserID] in table [People] has been modified so that it no longer accepts null values
---- by using the following line of code

 alter table [People] alter column [CreatedBy_UserID] int not null;

create index i_PersonID on [Phones] ([Person_ID]);
alter table [Phones] add constraint unq_PhoneNumber unique ([Phone_Number]);
insert into [Phones] values ('01001978166', 1);

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

--select * from [vPeopleRegisteredInAppointmentRenewLicense] where Test_ID = 1 and Is_Completed = 0;

----=====================================

create view vGetLicenseClassInfoByApplicationID as
select [License_Categories].*, [Orders].[Order_ID], [Orders].[Person_ID], [Orders].[Order_Status_ID]
from [Orders] join [New_Local_Licenses_Order]
on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID]
join [License_Categories] 
on [New_Local_Licenses_Order].[License_Category_ID] = [License_Categories].[License_Category_ID];

--select * from [vGetLicenseClassInfoByApplicationID] where [Order_ID] = 40;

----=====================================

create view vDoesHaveLicenseOfSameClass as
select [People].[Person_ID], [Licenses].* 
from [People] join [Drivers] on [People].[Person_ID] = [Drivers].[Person_ID]
join [Licenses] on [Drivers].[Driver_ID] = [Licenses].[Driver_ID];

--select * from [vDoesHaveLicenseOfSameClass] where [Person_ID] = 61 and [License_Category_ID] = 3;

----=====================================

create view [vFindPersonByLicenseID] as
select [People].*, [License_ID], [User_Name] from 
[Licenses] join [Drivers] on [Licenses].[Driver_ID] = [Drivers].[Driver_ID]
join [People] on [Drivers].[Person_ID] = [People].[Person_ID]
join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID];


--select * from [vFindPersonByLicenseID] where [License_ID] = 1;

----=====================================

create view [vLicensesInfo] as
select [People].[Person_ID], [People].[National_Number], [Licenses].*, [Category_Name], [Users].[User_Name]
from [Licenses] join [Drivers] on [Licenses].[Driver_ID] = [Drivers].[Driver_ID]
join [People] on [Drivers].[Person_ID] = [People].[Person_ID]
join [Licenses_Status] on [Licenses].[License_Status_ID] = [Licenses_Status].[License_Status_ID]
join [License_Categories] on [Licenses].[License_Category_ID] = [License_Categories].[License_Category_ID]
join [Users] on [Licenses].[CreatedBy_UserID] = [Users].[User_ID];

--select * from [vLicensesInfo];

----=====================================

create view [vNewLocalLicensesOrders] as
select [Orders].*, [User_Name], [Passed_Tests], [License_Category_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [New_Local_Licenses_Order] on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID];

--select * from [vNewLocalLicensesOrders];

----=====================================

create view [vRenewLicensesOrders] as
select [Orders].*, [User_Name], [Test_Result], [Enrollment_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
left join [Enrollments] on [Orders].[Order_ID] = [Enrollments].[RetakeTestOrderID];

--select * from [vRenewLicensesOrders];

----=====================================

create view [vNewLocalLicensesOrdersForNationalNumber] as
select [Orders].*, [User_Name], [Passed_Tests], [National_number], [License_Category_ID]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [People] on [People].[Person_ID] = [Orders].[Person_ID]
join [New_Local_Licenses_Order] on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID];

--select * from [vNewLocalLicensesOrdersForNationalNumber];

----=====================================

create view [vRenewLicensesOrdersForNationalNumber] as
select [Orders].*, [User_Name], [Test_Result], [Enrollment_ID], [National_number]
from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
join [People] on [People].[Person_ID] = [Orders].[Person_ID]
left join [Enrollments] on [Orders].[Order_ID] = [Enrollments].[RetakeTestOrderID];

--select * from [vRenewLicensesOrdersForNationalNumber];

----==============================================================================================================


select * from [Orders_Status];
select * from [Licenses_Status];
select * from [Services_Types];
select * from [Tests];
select * from [License_Categories];

select * from [People];
select * from [Phones];
select * from [Users];

select * from [New_Local_Licenses_Order];
select * from [Enrollments];
select * from [Orders];
select * from [Tests_Appointments];

select * from [Drivers];
select * from [Licenses];
select * from [Release_Licenses_Reservation_Order];
select * from [International_Licenses];


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
