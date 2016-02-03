using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LDTBXH
{
    class LaygiatriPhai
    {
        public static int GetPhai(RadioButton rdnam,RadioButton rdnu)
        {
            if (rdnam.Checked == true)
                return 1;
            else
                return 0;
        }
    }
}
