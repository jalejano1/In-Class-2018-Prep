<Query Kind="Expression">
  <Connection>
    <ID>3b32162c-a1db-467a-9f7a-d43c858a0e27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>FSIS_2018</Database>
  </Connection>
</Query>

//3. 

from s in Teams
orderby s.TeamName 
select new
{
	Team = s.TeamName,
	Coach = s.Coach,
	Players = from w in s.Players
			  orderby w.LastName,w.FirstName
			  select new 
			  {
			  	LastName = w.LastName,
				FirstName = w.FirstName,
				Gender = w.Gender.Equals("F") ? "Female" : "Male",
				Age = w.Age
			  }
			  
}