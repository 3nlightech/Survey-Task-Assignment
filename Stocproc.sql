Use Pool_DB;

Set ANSI_Nulls On 
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc StatsInfo
@Surname varchar (25),
@Name varchar (25),
@Phone varchar (25), 
@Reg_Date datetime,
@Age varchar (25), 
@Fav_Food varchar (25), 
@EatOut int, 
@WatchMovie int, 
@WatchTV int, 
@ListenRadio int

as
begin
Insert into Survey_Test (Surname, F_Names, Phone, Reg_Date, Age, Fav_Food, Eatout, WatchMovie, WatchTV, ListenRadio) 
values (@Surname, @Name, @Phone, @Reg_Date, @Age, @Fav_Food, @EatOut, @WatchMovie, @WatchTV, @ListenRadio)
end