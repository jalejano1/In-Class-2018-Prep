<Query Kind="Expression">
  <Connection>
    <ID>3b32162c-a1db-467a-9f7a-d43c858a0e27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>FSIS_2018</Database>
  </Connection>
</Query>

// 1.) 

from s in Guardians
where s.Players.Count > 1
orderby s.Players.Count descending
select new 
{
	Name = s.FirstName + " " + s.LastName,
	Children = from w in s.Players
			   orderby w.Age ascending
			   select new 
			   {
			   		Name = w.FirstName + " " + w.LastName,
					Age = w.Age,
					Gender = w.Gender,
					Team = w.Team.TeamName
			   }
}