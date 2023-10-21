using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp1.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Play Mode Name")]
        [Required(ErrorMessage ="Play mode name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Play mode name must be between 3 and 50 characters")]

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Name { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        [DisplayName("Observation")]
        [Required(ErrorMessage ="Play mode observation is required")]
        [StringLength(200, MinimumLength = 3,ErrorMessage ="Play mode observation must between 3 and 200 characters")]
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Observation { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

    }
}
