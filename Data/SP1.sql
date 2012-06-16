SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE HomeScoreAdd 
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set HomeScore = HomeScore + 1 where MatchId = @MatchId and GameId = @GameId
END
GO

CREATE PROCEDURE GuestScoreAdd 
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set GuestScore = GuestScore + 1 where MatchId = @MatchId and GameId = @GameId
END
GO

CREATE PROCEDURE HomeScoreSubtract
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set HomeScore = HomeScore - 1 where MatchId = @MatchId and GameId = @GameId
END
GO

CREATE PROCEDURE GuestScoreSubtract 
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set GuestScore = GuestScore - 1 where MatchId = @MatchId and GameId = @GameId
END
GO

CREATE PROCEDURE ClearSet 
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set HomeScore = 0, GuestScore = 0 where MatchId = @MatchId and GameId = @GameId
END
GO

CREATE PROCEDURE RemoveSet 
	@MatchId int, 
	@GameId int
AS
BEGIN
	SET NOCOUNT ON;
	update Game set HomeScore = NULL, GuestScore = NULL where MatchId = @MatchId and GameId = @GameId
END
GO

