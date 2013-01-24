use DLCup

-- Bara de nya spelarna behöver läggas in
insert into Player (PlayerName, TeamId) select 'Oskar R', TeamId from Team where TeamName = 'Decerno'
insert into Player (PlayerName, TeamId) select 'Martin', TeamId from Team where TeamName = 'Fastighetsbyrån'
insert into Player (PlayerName, TeamId) select 'Marcus', TeamId from Team where TeamName = 'Decerno'
select * from Player

insert into Cup (CupName, CupDate, HomeTeamId, GuestTeamId)
select
	'DL Cup #2',
	'2012-12-12 18:00:00',
	HomeTeamId = (select TeamId from Team where TeamName = 'Decerno'),
	GuestTeamId = (select TeamId from Team where TeamName = 'Fastighetsbyrån')
select * from Cup

insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 1, 1, (select CupId from Cup where CupName = 'DL Cup #2')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 2, 2, (select CupId from Cup where CupName = 'DL Cup #2')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 3, 2, (select CupId from Cup where CupName = 'DL Cup #2')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'S', 4, 2, (select CupId from Cup where CupName = 'DL Cup #2')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'D', 5, 3, (select CupId from Cup where CupName = 'DL Cup #2')
insert into Match (MatchType, PlayOrder, Points, CupId) select 'D', 6, 5, (select CupId from Cup where CupName = 'DL Cup #2')
select * from Match where CupId = (select CupId from Cup where CupName = 'DL Cup #2')

-- Första set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup #2')

-- Andra set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup #2')

-- Tredje set
insert into Game (HomeScore, GuestScore, MatchId)
select null, null, MatchId
from Match where CupId = (select CupId from Cup where CupName = 'DL Cup #2')

-- Kontrollera alla set
select MatchType, PlayOrder, GameId from Game g
inner join Match m on m.MatchId = g.MatchId
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2'
order by m.MatchId, GameId


S Martin
S Matti
S Andreas
S 
D Andreas och Martin
D Matti och Andreas


-- Tilldela spelare till varje match
update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Oskar R'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Martin')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 1

update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Marcus'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Matti')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 2

update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Karin'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Andreas')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 3

update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Björn'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Martin')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 4

update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Karin'),
    SecondaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Oskar R'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Andreas'),
    SecondaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Martin')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 5

update m
set PrimaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Marcus'),
    SecondaryHomePlayerId = (select PlayerId from Player where PlayerName = 'Björn'),
    PrimaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Matti'),
    SecondaryGuestPlayerId = (select PlayerId from Player where PlayerName = 'Andreas')
--select count(*)
from Match m
inner join Cup c on c.CupId = m.CupId
where c.CupName = 'DL Cup #2' and m.PlayOrder = 6
