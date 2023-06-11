using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Crypto;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.IO.Pipelines;
using System.Net.Mail;
using System.Numerics;
using System.Security.Policy;
using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Models
{
    public class Approval
    {


        //Permit Number: PTW-2023-001
        [Display(Name="Permit Number")]
        public string Permit_NO { get; set; }

        [Display(Name="Date Issued")]
        public DateTime Date { get; set; }
        //Date: May 26, 2023

        //: John Smith
        [Display(Name = "Permit Issuer")]
        public string Permit_Issuer { get; set; }
        //Permit Approver: Jane Doe
        [Display(Name = "Permit Approver")]
        public string Permit_Approver { get; set; }
        //Work Details:
        //- Type of Work: Electrical Maintenance
        [Display(Name = "Type of Work")]
        public string Type_of_work { get; set; }
        //- Location: Building XYZ
        [Display(Name = "Location")]
        public string Location { get; set; }
        //- Work Description: Repair and replace electrical wiring in the main control panel.
        [Display(Name = "Work Description")]
        public string Work_Description { get; set; }
        //Hazard Assessment:
        //- Electrical hazards identified and assessed.
        [Display(Name = "Hazard Assessment")]
        public string Hazard_Assessment { get; set; }
        //- Mitigation measures in place: Proper lockout-tagout procedures followed.Only authorized personnel allowed in the work area.Personal protective equipment (PPE) required.
        [Display(Name = "Mitigation measures in place")]
        public string Mitigation_measures{ get; set; }
        //Isolation of Hazardous Energy:
        [Display(Name = "Isolation of Hazardous Energy")]
        public string Isolation_of_Hazardous_Energy { get; set; }
        //- Electrical isolation completed and verified by a qualified electrician.
        //- Lockout-Tagout (LOTO) devices applied to the control panel.
        //- Equipment shutdown and verification conducted.

        //Bypassing Critical Protections:
        //- No critical protections bypassed.
        [Display(Name = "Bypassing Critical Protections")]
        public string Bypassing_Critical_Protections { get; set; }

        //Access:
        [Display(Name = "Access")]
        public string Access{ get; set; }
        //- Ladders and scaffolding provided for safe access to work areas.

        //Barricade/Restrict Access:
        //- Work area barricaded to prevent unauthorized access.
        [Display(Name = "Barricade/Restrict Access")]
        public string Barricade_Restrict_Access { get; set; }

        //Critical Lift:
        //- Not applicable.
        [Display(Name = "Critical Lift")]
        public string Critical_Lift { get; set; }

        //Night Work Special Lighting:
        //- Hazardous location-rated lighting installed for night work.
        [Display(Name = "Night Work Special Lightingt")]
        public string Night_Work_Special_Lighting { get; set; }

        //JSA Reviewed and Confirmed Adequate:
        //- Job Safety Analysis (JSA) reviewed and approved.
        //- Attached JSA document for reference.
        [Display(Name = "Confirmed Adequate")]
        public string Confirmed_Adequate { get; set; }

        //Other Special Requirements:
        //- None.
        [Display(Name = "Other Special Requirements")]
        public string Other_Special_Requirements { get; set; }


        //Gas Testing Requirements:
        //- Gas testing not required for this work.
        [Display(Name = "Gas Testing Requirements")]
        public string Gas_Testing_Requirements { get; set; }

        //Permit Duration:
        //- Start Date: May 26, 2023, 08:00 AM
        [Display(Name = "Start Date")]
        public DateTime Start_Date { get; set; }
        //- End Date: May 26, 2023, 05:00 PM
        [Display(Name = "End Date")]
        public DateTime End_Date { get; set; }

        //Permit Closure:
        //- Work completed as per the permit requirements.
        //- All tools and equipment accounted for.
        //- Permit closed and signed by the permit approver.
        [Display(Name = "Permit Closure")]
        public string Permit_Closure { get; set; }

        public string Permit_approval_Consent { get; set; }

    }
}
