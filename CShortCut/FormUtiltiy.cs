using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShortCut
{
    internal class FormUtiltiy
    {
        public static bool IsOpenForm(string formName)
        {
            var openForm = Application.OpenForms.Cast<Form>();
            var IsOpenForm = openForm.Any(q => q.Name == formName);

            return IsOpenForm;
        }
    }
}
