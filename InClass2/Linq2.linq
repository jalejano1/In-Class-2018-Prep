<Query Kind="Expression">
  <Connection>
    <ID>3b32162c-a1db-467a-9f7a-d43c858a0e27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>FSIS_2018</Database>
  </Connection>
</Query>

//2.)


from s in Players
group s by s.Gender into GenderCount
select new 
{
	Gender = GenderCount.Key.Equals("F") ?  "Female" : "Male",
	Count = GenderCount.Count()
}
