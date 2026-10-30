static class Badge
{
    public static string Print(int? id, string name, string? department){
        string idStr = id == null ? "" : $"[{id}] - ";         
      return $"{idStr}{name} - {department?.ToUpper()??"OWNER"}";  
    }
}
