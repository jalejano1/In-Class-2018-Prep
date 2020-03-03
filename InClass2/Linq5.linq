<Query Kind="Program">
  <Connection>
    <ID>3b32162c-a1db-467a-9f7a-d43c858a0e27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>FSIS_2018</Database>
  </Connection>
</Query>

void Main()
{
	//5. 
	
	var w = from s in Teams
			select new
			{
				TeamName = s.TeamName,
				Wins = s.Wins
			};
			
	w.Dump(); 
}

// Define other methods and classes here
