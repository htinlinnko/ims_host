CREATE TABLE [dbo].[ims_user]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [staff_id] VARCHAR(50) NULL, 
    [user_name] VARCHAR(50) NULL, 
    [first_name] VARCHAR(200) NULL, 
    [middle_name] VARCHAR(200) NULL, 
    [last_name] VARCHAR(200) NULL, 
    [active] BIT NOT NULL, 
    [inactive_date] DATETIME NULL, 
    [password] VARCHAR(200) NULL
)
