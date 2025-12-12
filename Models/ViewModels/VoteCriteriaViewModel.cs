using System.ComponentModel.DataAnnotations;

public class VoteCriteriaViewModel
{
    [Required(ErrorMessage = SharedResource.RequireMessage)]
    [Display(Name = "Назва")]
    public string Title { get; set; }
    [Display(Name = "Опис")]
    public string Description { get; set; }

    [Range(0, 100)]
    [Display(Name = "Важливість")]
    public double? Importance { get; set; }
    [Range(0, double.MaxValue)]
    [Display(Name = "Мінімальне значення")]
    public double MinValue { get; set; } = 0;
    [Range(0, double.MaxValue)]
    [Display(Name = "Крок")]
    public double StepValue { get; set; } = 0;
    [Range(0, double.MaxValue)]
    [Display(Name = "Максимальне значення")]
    public double MaxValue { get; set; } = 10;
}