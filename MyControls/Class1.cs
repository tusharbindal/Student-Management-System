using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls
{
    public class ComboItem
    {
        public string ID;
        public string Name;

        public ComboItem()
        {

        }

       public ComboItem(string _id, string _name)
        {
            ID = _id;
            Name = _name;
        }

        public override string ToString()
        {
            return Name;
        }
        
    }

    public static class ControlUtility
    {
        public static void SetComboItem(System.Windows.Forms.ComboBox cmb, string ID)
        {
            if (cmb.Items == null || cmb.Items.Count <= 0)
            {
                return;
            }

            for (int index = 0; index < cmb.Items.Count - 1; index++)
            {
                ComboItem item = cmb.Items[index] as ComboItem;
                if (item.ID == ID)
                {
                    cmb.SelectedIndex = index;
                    break;
                }
            }
           
    }

    }
}