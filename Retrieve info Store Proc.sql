CREATE PROCEDURE retrieveInfo
AS
BEGIN
DECLARE
@Total int,
@Average int,
@Maxi int,
@Mini int,
@EatPizza int,
@EatPasta int,
@EatPapWors int,
@EatoutAVG decimal(6, 1),
@WatchMovieAVG decimal(6, 1),
@WatchTVAVG decimal(6, 1),
@ListenRadioAVG decimal(6, 1);


 SELECT @Total = COUNT(*) FROM [dbo].[Survey_Test];
 SELECT @Average = AVG(Age) from [dbo].[Survey_Test];
 SELECT @Maxi = MAX(Age) from [dbo].[Survey_Test];
 SELECT @Mini = MIN(Age) from [dbo].[Survey_Test];
 SELECT @EatPizza = COUNT(*) from [dbo].[Survey_Test] where Fav_Food='Pizza';
 SELECT @EatPasta = COUNT(*) from [dbo].[Survey_Test] where Fav_Food='Pasta';
 SELECT @EatPapWors = COUNT(*) from [dbo].[Survey_Test] where Fav_Food='Pap and Wors';
 SELECT @EatoutAVG = AVG(EatOut) from [dbo].[Survey_Test];
 SELECT @WatchMovieAVG = AVG(WatchMovie) from [dbo].[Survey_Test];
 SELECT @WatchTVAVG = AVG(WatchTV) from [dbo].[Survey_Test];
 SELECT @ListenRadioAVG = AVG(ListenRadio) from [dbo].[Survey_Test];

 SELECT @Total AS Total;
 SELECT @Average AS Average;
 SELECT @Maxi AS Maxi;
 SELECT @Mini AS Mini;
 SELECT @EatPizza AS EatPizza;
 SELECT @EatPasta AS EatPasta;
 SELECT @EatPapWors AS EatPapWors;
 SELECT @EatoutAVG AS EatoutAVG;
 SELECT @WatchMovieAVG AS WatchMovieAVG;
 SELECT @WatchTVAVG AS WatchTVAVG;
 SELECT @ListenRadioAVG AS ListenRadioAVG;

End