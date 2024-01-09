drop database MMS;

create database MMS;

create table Registration_Keys
(
	[Key_ID] int primary key identity(1,1),
	[Key] nvarchar(max) not null,
	[Key_Validation] date not null,
	[Key_Status] int not null
);

create table Shop(
Shop_ID int primary key identity(1,1),
[Key_ID] nvarchar(max) not null,
Shop_Name nvarchar(max) not null,
Shop_logo image not null,
Shop_Contact1 nvarchar(max) not null,
Shop_Contact2 nvarchar(max),
Shop_Address nvarchar(max) not null,
Shop_EmailAddress nvarchar(max) not null,
Shop_Owner nvarchar(max) not null,
Shop_RegistrationYear date not null,
Shop_Status int
);


create table Users (
[User_ID] int primary key identity(1,1),
User_Profile image not null,
[User_FirstName] nvarchar(max) not null,
User_LastName nvarchar(max) not null,
User_Email nvarchar(max) not null,
User_Phone nvarchar(max) not null,
User_Role int not null,
User_Username nvarchar(max) not null,
User_Password nvarchar(max) not null,
User_Status int not null 
);

create procedure User_Verification
@username int,
@password int,
@status int = 1
as

BEGIN
	select 
		[User_ID],
		User_Profile,
		[User_FirstName] ,
		User_LastName ,
		User_Email ,
		User_Phone,
		User_Role
	from Users

	where User_Username = @username and 
			User_Password = @password and 
				User_Status = @status;
END

create procedure Registration_Verification

as
	select 
		Registration_ID 
	from Registration;

create procedure Add_User
@Profile image,
@FirstName nvarchar(max),
@LastName nvarchar(max),
@Email nvarchar(max),
@Phone nvarchar(max),
@Role int,
@Username nvarchar(max),
@Password nvarchar(max),
@Status int = 1

as
	/* Username should be unique for each account */
	if((select count([User_ID]) from Users where User_Username = @Username) = 0)
	BEGIN
		insert into Users
		values (
			@Profile,
			@FirstName,
			@LastName,
			@Email,
			@Phone ,
			@Role ,
			@Username ,
			@Password ,
			@Status 
		);
	END
	else return 0


create procedure Add_Shop

@Registration_key nvarchar(max),
@Shopname nvarchar(max),
@logo image,
@Contact1 nvarchar(max) ,
@Contact2 nvarchar(max),
@Address nvarchar(max) ,
@Owner nvarchar(max) ,
@current_date date,
@Shop_Status int = 1

as
BEGIN
	/* Verifying Key */
	if((select count([Key_ID]) from Registration_Keys where [Key] = @Registration_key and Key_Status != 1) > 0)
	Begin
		/* Insert new Entry*/
		insert into Shop
		(
			[Key_ID],
			Shop_Name,
			Shop_logo,
			Shop_Contact1,
			Shop_Contact2,
			Shop_Address,
			Shop_Owner,
			Shop_RegistrationYear,
			Shop_Status
		)
		values
		(
			(select Top 1 [Key_ID] from Registration_Keys where [Key] = @Registration_key),
			@Shopname,
			@logo,
			@Contact1,
			@Contact2,
			@Address,
			@Owner,
			@current_date,
			@Shop_Status
		);
	END
	Else return 0;
END

create procedure Update_User
@id int,
@Profile image,
@FirstName nvarchar(max),
@LastName nvarchar(max),
@Email nvarchar(max),
@Phone nvarchar(max),
@Role int,
@old_Username nvarchar(max),
@old_Password nvarchar(max),
@new_Username nvarchar(max),
@new_Password nvarchar(max),
@Status int = 1

as
	/* Username should be unique for each account except the existing one */
	if((select count([User_ID]) from Users where User_Username = @old_Username and User_password = @old_Password) = 1)
	BEGIN
		update Users
		set 
			User_Profile = @Profile,
			[User_FirstName] = @FirstName,
			User_LastName = @LastName,
			User_Email = @Email,
			User_Phone = @Phone ,
			User_Role = @Role ,
			User_Username = @new_Username,
			User_Password = @new_Password,
			User_Status = @Status
		where User_ID = @id
	END
	else return 0
