using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Nations.Props
{
    public enum NationProps
    {
        nName,
        nPop,
        nArms
    }
    public enum NationBoolProp
    {
        True,
        False,
    }

    public class NationBool
    {
        NationBoolProp myBool;
        public NationBool()
        {
        }
        public NationBoolProp MyBool
        {
            get
            {
                return myBool;
            }
            set
            {
                myBool = value;
            }
        }
    }

    public class NewNation
    {
        NationProps nObj;    
           
        public NewNation()
        {
        }
        public NationProps EnumProperty
        {
            get
            {
                return nObj;
            }
            set
            {
                nObj = value;
            }
        }
    }
}
