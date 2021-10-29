

create database Airline_ticket


use Airline_ticket




create table FlightTypes
(
IdFlightType int primary key IDENTITY (1,1) NOT NULL,
[Flight Type]  nvarchar(max) NOT NULL,

Constraint CK_Flight_Type Check([Flight Type] <>' ')
)


insert into FlightTypes([Flight Type])
values
(N'Premium')


create table Schedules
(
IdSchedule int primary key IDENTITY (1,1) NOT NULL,
[Date In] datetime NOT NULL,
[Date out] datetime NOT NULL,

Constraint CK_Date_In Check([Date In] <>' '),
Constraint CK_Date_out Check([Date out] <>' ')
)


insert into Schedules([Date In],[Date out])
values
(CAST(N'2021-05-17 00:00:00.000' AS DateTime),CAST(N'2021-06-17 00:00:00.000' AS DateTime))


create table Airplanes
(
IdAirplane int primary key IDENTITY (1,1) NOT NULL,
[Name of Airplane] nvarchar(max) NOT NULL,
[Passengers' count] bigint NOT NULL,

Constraint CK_Name_of_Airplane Check([Name of Airplane] <>' '),
Constraint CK_Passengers_count Check([Passengers' count] <>' ')
)


insert into Airplanes([Name of Airplane],[Passengers' count])
values ('Airplane_1',600)


create table Pilots
(
IdPilot int primary key IDENTITY (1,1) NOT NULL,
[Pilots name]  nvarchar(max) NOT NULL,
[Pilots surname]  nvarchar(max) NOT NULL,

Constraint CK_Pilots_name Check([Pilots name] <>' '),
Constraint CK_Pilots_surname Check([Pilots surname] <>' ')
)


insert into Pilots ([Pilots name],[Pilots surname])
values(N'Pilot''s name', N'Pilot''s surname')


create table AirplanePilots
(
IdAirplanePilot int primary key IDENTITY (1,1) NOT NULL,

PilotsId int NOT NULL,
AirplanesId int NOT NULL,

Constraint FK_PilotId Foreign key (PilotsId) References Pilots(IdPilot) On Delete CASCADE On Update CASCADE,
Constraint FK_AirplaneId Foreign key (AirplanesId) References Airplanes(IdAirplane) On Delete CASCADE On Update CASCADE
)


insert into AirplanePilots(PilotsId,AirplanesId)
values(1,1)


create table Cities
(
IdCity int primary key IDENTITY (1,1) NOT NULL,
[From City] nvarchar(max) NOT NULL,
[To City] nvarchar(max) NOT NULL,

Constraint CK_From_City Check([From City] <>' '),
Constraint CK_To_City Check([To City] <>' ')
)


insert into Cities([From City],[To City])
values(N'Baku', N'Gandja')



create table Tickets
(
IdTicket int primary key IDENTITY (1,1) NOT NULL,
[Code of Ticket] nvarchar(max),

Constraint CK_Code_of_Ticket Check([Code of Ticket] <>' '),

FlightTypesId int NOT NULL,
SchedulesId int NOT NULL,
AirplanePilotsId int NOT NULL,
CitiesId int NOT NULL,

Constraint FK_FlightTypeId Foreign key (FlightTypesId) References FlightTypes(IdFlightType) On Delete CASCADE On Update CASCADE,
Constraint FK_SchedulesId Foreign key (SchedulesId) References Schedules(IdSchedule) On Delete CASCADE On Update CASCADE,
Constraint FK_AirplanePilotsId Foreign key (AirplanePilotsId) References AirplanePilots(IdAirplanePilot) On Delete CASCADE On Update CASCADE,
Constraint FK_CitiesId Foreign key (CitiesId) References Cities(IdCity) On Delete CASCADE On Update CASCADE
)


insert into Tickets ([Code of Ticket], FlightTypesId,SchedulesId,AirplanePilotsId, CitiesId)
values(N'Code1',1,1,1,1)


select *from Tickets
Inner Join AirplanePilots
On
Tickets.AirplanePilotsId= AirplanePilots.IdAirplanePilot
Inner Join Pilots
on
AirplanePilots.PilotsId= Pilots.IdPilot
Inner Join Airplanes
on
AirplanePilots.AirplanesId= Airplanes.IdAirplane



select *from AirplanePilots

select *from Pilots

select *from Airplanes

select *from Cities

select *from FlightTypes

select *from Schedules