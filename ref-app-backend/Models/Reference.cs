namespace ref_app_backend.Models;

public class Reference
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Creator { get; set; }
    public string Date { get; set; }
    public string Language { get; set; }

    public Reference()
    {
        
    }

    public Reference(ReferenceDTO dto)
    {
        Id = dto.Id;
        Identifier = dto.Identifier;
        Title = dto.Title;
        Type = dto.Type;
        Creator = dto.Creator;
        Date = dto.Date;
        Language = dto.Language;
    }
}