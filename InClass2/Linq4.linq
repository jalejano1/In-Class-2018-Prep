<Query Kind="Expression">
  <Connection>
    <ID>3b32162c-a1db-467a-9f7a-d43c858a0e27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>FSIS_2018</Database>
  </Connection>
</Query>

//4.)

from s in PlayerStats
orderby s.Player.FirstName
select new 
{
   name = s.Player.FirstName + " " + s.Player.LastName,
   teamname = s.Player.Team.TeamName,
   goals = s.Goals,
   assists = s.Assists,
   redcards = s.RedCard.Equals("False") ? 0 :  s.RedCard.Equals("True") ? 1 : 1,
   yellowcard = s.YellowCard.Equals("False") ? 0 : s.YellowCard.Equals("True") ? 1 : 1
}