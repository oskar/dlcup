use DLCup

delete from Cup
delete from Team
dbcc CHECKIDENT(Cup, RESEED, 0); -- reset identity
dbcc CHECKIDENT(Match, RESEED, 0); -- reset identity
dbcc CHECKIDENT(Game, RESEED, 0); -- reset identity
dbcc CHECKIDENT(Team, RESEED, 0); -- reset identity
dbcc CHECKIDENT(Player, RESEED, 0); -- reset identity

insert into Team (TeamName) values ('Decerno')
insert into Team (TeamName) values ('Fastighetsbyrån')
select * from Team

insert into Player (PlayerName, TeamId) select 'Oskar', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Mikael', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Sofi', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Björn', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Karin', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Daniel', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Marcus', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Jakob', TeamId from Team where TeamName = 'Fastighetsbyrån'
insert into Player (PlayerName, TeamId) select 'Andreas', TeamId from Team where TeamName = 'Fastighetsbyrån'
insert into Player (PlayerName, TeamId) select 'Matti', TeamId from Team where TeamName = 'Fastighetsbyrån'
insert into Player (PlayerName, TeamId) select 'Johan', TeamId from Team where TeamName = 'Fastighetsbyrån'
select * from Player

insert into Cup (CupName, CupDate, HomeTeamId, GuestTeamId)
select
	'DL Cup 2012',
	'2012-05-03 18:30:00',
	HomeTeamId = (select TeamId from Team where TeamName = 'Decerno'),
	GuestTeamId = (select TeamId from Team where TeamName = 'Fastighetsbyrån')
select * from Cup

insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 1, 1, (select CupId from Cup where CupName = 'DL Cup 2012')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'D', 2, 2, (select CupId from Cup where CupName = 'DL Cup 2012')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 3, 3, (select CupId from Cup where CupName = 'DL Cup 2012')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'D', 4, 4, (select CupId from Cup where CupName = 'DL Cup 2012')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 5, 5, (select CupId from Cup where CupName = 'DL Cup 2012')
select * from Match

-- Första set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup 2012')

-- Andra set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup 2012')

-- Tredje set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup 2012')


select MatchType, PlayOrder, GameId from Game g
inner join MAtch m on m.MatchId = g.MatchId
order by m.MatchId, GameId


update Match set PrimaryHomePlayerId = 1, PrimaryGuestPlayerId = 8 where MatchId = 1
update Game set HomeScore = 11, GuestScore = 7 where GameId = 1
update Game set HomeScore = 3, GuestScore = 11 where GameId = 6
update Game set HomeScore = 11, GuestScore = 13 where GameId = 11

update Match set PrimaryHomePlayerId = 2, PrimaryGuestPlayerId = 9 where MatchId = 2
update Match set SecondaryHomePlayerId = 3, SecondaryGuestPlayerId = 10 where MatchId = 2

update Game set HomeScore = 11, GuestScore = 0 where GameId = 2

update Match set PrimaryHomePlayerId = 2 where MatchId = 3
