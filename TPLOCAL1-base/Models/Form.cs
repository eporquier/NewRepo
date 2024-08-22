using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TPLOCAL1.Models
{
    public class FormModel
    {
        //[Required(ErrorMessage = "Veuillez saisir votre nom")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "Le nom de famille doit être compris entre 4 et 30 caractères ")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre prénom")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "Le prénom doit comporter entre 4 et 30 caractères")]
        public string Forname { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre genre")]
        public string Gender { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre adresse")]
        //[StringLength(30, MinimumLength = 5, ErrorMessage = "Adresse trop courte")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Le code postal est obligatoire")]
        //[RegularExpression(@"[0-9]{5}", ErrorMessage = "Veuillez saisir un code postal valide")]
        public string ZipCode { get; set; }


        //[Required(ErrorMessage = "Veuillez saisir votre ville")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "La ville doit être comprise entre 4 et 30 caractères")]
        public string Town { get; set; }

        //[Required(ErrorMessage = "L'adresse électronique est obligatoire")]
        //[RegularExpression(@"^([\w] +)@([\w] +)\.([\w] +)$", ErrorMessage = "Veuillez saisir une adresse électronique valide")]
        public string Email { get; set; }

        //[Required]
        public DateTime StartDate { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre formation")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "L'intitulé de formation doit être compris entre 4 et 30 caractères ")]
        public string Formation { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre avid")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "L'avis doit être compris entre 4 et 30 caractères ")]
        public string CobolTraining { get; set; }

        //[Required(ErrorMessage = "Veuillez saisir votre avid")]
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "L'avis doit être compris entre 4 et 30 caractères ")]
        public string CShapTraining { get; set; }
    }
}