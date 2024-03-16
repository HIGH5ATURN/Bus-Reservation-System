Create table Driver
(
    DriverID varchar2(11) ,
    name varchar2(50),
    LicenseNumber number,
    ContactNumber varchar2(11),
    DOB Date,
    CONSTRAINT pk_Driver primary key(DriverID),
        CONSTRAINT check_ReceptionistcontactNumber_format
    CHECK (REGEXP_LIKE(ContactNumber, '^01[0-9]{9}'))
);

Create table Bus
(
    BusNumber varchar2(11),
    model varchar2(50),
    capacity number,
    CONSTRAINT pk_Bus primary key(BusNumber)
);

CREATE TABLE BusDriverAssignment
(
    BusDriverAssignmentID NUMBER UNIQUE NOT NULL,
    DriverID varchar2(11),
    BusNumber varchar2(11),
    CONSTRAINT fk_DriverID Foreign key(DriverID) references Driver(DriverID),
    CONSTRAINT fk_BusNumber Foreign key(BusNumber) references Bus(BusNumber),
    CONSTRAINT pk_BusDriverAssignment primary key(DriverID,BusNumber)
);

CREATE TABLE Conductor
(
  ConductorID varchar2(11),
  name varchar2(50),
  ContactNumber varchar2(11) ,
      DOB Date,
  CONSTRAINT pk_Conductor primary key(ConductorID),
      CONSTRAINT check_ReceptionistcontactNumber_format
    CHECK (REGEXP_LIKE(ContactNumber, '^01[0-9]{9}'))
);

Create or REPLACE type TimeDiff as OBJECT --Custom Datatype to keep the time difference
(
  hour Number(4,0),
  min Number(2,0)
);
CREATE TABLE Station
(
    StationName varchar2(50),
    CONSTRAINT pk_Station primary key (StationName)
);
CREATE TABLE Route
(
    RouteID number,
    Origin varchar2(50),
    Destination varchar2(50),
    Distance NUMBER,
    Duration TimeDiff,
    CONSTRAINT pk_Route primary key(RouteID),
    CONSTRAINT fk_origin foreign key (Origin) references Station(StationName),
    CONSTRAINT fk_destination foreign key (Destination) references Station(StationName)
);

CREATE TABLE Schedule
(
    ScheduleID NUMBER,
    DepartureTime Date NOT NULL,
    ArrivalTime Date,
    Fare NUMBER NOT NULL,
    BusDriverAssignmentID NUMBER,
    ConductorID varchar2(11),
    RouteID NUMBER,
    CONSTRAINT pk_Schedule primary key(ScheduleID),
    CONSTRAINT fk_BusDriverAssignmentID Foreign key(BusDriverAssignmentID) references BusDriverAssignment(BusDriverAssignmentID),
    CONSTRAINT fk_ConductorID Foreign key(ConductorID) references Conductor(ConductorID),
    CONSTRAINT fk_RouteID Foreign key(RouteID) references Route(RouteID)
);

CREATE TABLE Passenger
(
    PassengerID NUMBER,
    name varchar2(50),
    email varchar2(50),
    phone NUMBER,
    CONSTRAINT pk_Passenger primary key(PassengerID),
    CONSTRAINT check_PassengercontactNumber_format
    CHECK (REGEXP_LIKE(phone, '^01[0-9]{9}')),
    CONSTRAINT check_Passenger_email
    check ( email like '%@%.com')
);
CREATE TABLE Receptionist
(
    ReceptionistID varchar2(11),
    name varchar2(50),
    ContactNumber varchar2(50),
    DoB DATE,--added new
    Password varchar2(50),
    CONSTRAINT pk_Receptionist primary key (ReceptionistID),
    CONSTRAINT check_ReceptionistcontactNumber_format
    CHECK (REGEXP_LIKE(ContactNumber, '^01[0-9]{9}'))
);
CREATE TABLE Reservation
(
    ReservationID NUMBER,
    SeatNumber  varchar2(3),
    ReservationTime Date,
    ScheduleID NUMBER,
    ReceptionistID varchar2(11),
    CONSTRAINT pk_Reservation primary key (ReservationID),
    CONSTRAINT fk_ScheduleID foreign key (ScheduleID) references Schedule(ScheduleID),
    CONSTRAINT fk_ReceptionistID foreign key (ReceptionistID) references Receptionist(ReceptionistID)
);

CREATE TABLE Payment
(
    PaymentID number,
    Amount NUMBER,
    PaymentDateTime NUMBER,
    PaymentMethod varchar2(20),
    ReservationID NUMBER,
    CONSTRAINT pk_Payment primary key (PaymentID),
    CONSTRAINT fk_ReservationID foreign key (ReservationID) references Reservation(ReservationID)
);

CREATE TABLE Trips
(
    tripID NUMBER,
    ScheduleID NUMBER,
    tripStatus varchar2(50),
    CONSTRAINT pk_Trip primary key (tripID)
);

-------------------------------------------------
--sequence for receptionist ID
Create SEQUENCE seq_Receptionist
minvalue 1
maxvalue 99999
start with 2
    cache 20
increment by 1;

--function to generate ID
CREATE or REPLACE FUNCTION genReceptionistID(p_Dob IN DATE)
return varchar2 AS
v_Dob DATE:=p_Dob;
v_id varchar2(11):='R';
v_exist number(1):=0;

Begin

    v_id:=v_id||TO_CHAR(v_Dob,'YYYY')||TO_CHAR(v_Dob,'MM')||LPAD(seq_Receptionist.nextval,3,0);

return v_id;
end;
/
--trigger for id generation
CREATE OR REPLACE TRIGGER receptionist_id_trigger
BEFORE INSERT ON receptionist
FOR EACH ROW
BEGIN
  :new.ReceptionistID:=genReceptionistID(:new.DoB);
END;
/

--login function given id, password
CREATE or REPLACE function Receptionist_login(p_id IN Receptionist.ReceptionistID%type,p_password IN RECEPTIONIST.password%type)
return varchar2 as

v_id Receptionist.receptionistID%type;
v_loggedIn varchar2(10):='false';
v_count Number:=0;

begin
    select count(*) into v_count
    from Receptionist
    where ReceptionistID=p_id and Password=p_password;

    if v_count>0 then
        v_loggedIn:='true';
    end if;

    return v_loggedIn;
end;
/


------------DRIVER ID GENERATION-----------------------

--we need a sequence
--we need a function
--we need a trigger
Create sequence seq_driver
minvalue 1
maxvalue 999
start with 1;

CREATE or REPLACE FUNCTION genDriverID(p_Dob IN DATE)
return varchar2 AS
v_Dob DATE:=p_Dob;
v_id varchar2(11):='R';
Begin
    v_id:=v_id||TO_CHAR(v_Dob,'YYYY')||TO_CHAR(v_Dob,'MM')||LPAD(seq_driver.nextval,3,0);
return v_id;
end;
/

CREATE OR REPLACE TRIGGER Driver_id_trigger
BEFORE INSERT ON Driver
FOR EACH ROW
BEGIN
  :new.DriverID:=genDriverID(:new.DoB);
END;
/

select * from Receptionist where REGEXP_LIKE(contactNumber, '^01[0-9]{9}');

ALTER TABLE Passenger
ADD CONSTRAINT check_Passenger_email
check ( email like '%@%.com');

delete
from Driver
where DriverID='R200308001';