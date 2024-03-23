using System.ComponentModel.DataAnnotations;

namespace Learn_Blazor_WebAssembly.Samples.ThreeStatesListForm;

public class FormModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    [MinLength(1, ErrorMessage = "Item not selected")]
    public List<string> SelectedLists { get; set; } = [];
}
