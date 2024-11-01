/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
  public Space (String name) : base(name)
  {
  }
  
  public void Welcome () {
    Console.WriteLine("You are now at "+name);
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (String exit in exits) {
      Console.WriteLine(" - "+exit);
    }
  }
  
  public void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
  
  List<NPC> NPCList = new List<NPC>();
  
  //+ Movement_in_room():
  public void Movement_in_room()
  {
    
  }
  //+ Move_to_NPC(NPC):
  public override string ToString()
  {
    return SuisideRisk; 
  }
  public override bool Equals(object NPCList_ToCompare)
  {
    if (((NPC)NPCList_ToCompare).NPCList() == NPCList)
    {
      return true;
      Console.WriteLine(SuisideRisk) 
    }

    return false;
  }
  //+ Display_Rooms():
  //+ Display_NPC's():
}
