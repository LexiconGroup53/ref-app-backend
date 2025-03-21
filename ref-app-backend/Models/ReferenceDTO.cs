namespace ref_app_backend.Models;

public class ReferenceDTO
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Creator { get; set; }
    public string Date { get; set; }
    public string Language { get; set; }


    public ReferenceDTO()
    {
        
    }
    
    public ReferenceDTO(Reference reference)
    {
        Id = reference.Id;
        Identifier = reference.Identifier;
        Title = reference.Title; 
        Creator = reference.Creator;
        Date = reference.Date;
        Language = reference.Language;
    }
}