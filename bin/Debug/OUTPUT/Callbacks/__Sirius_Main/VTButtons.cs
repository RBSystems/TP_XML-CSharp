using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Crestron.SimplSharp;

using Crestron.ThirdPartyCommon.Class;
using Crestron.ThirdPartyCommon.ComponentInterfaces;
using Crestron.ThirdPartyCommon.Interfaces;
using Crestron.ThirdPartyCommon.StandardCommands;
using Crestron.ThirdPartyCommon.Transports;

using VTPro.Objects;
using VTPro.SmartObjects;

using myNamespace.Drivers;

using myNamespace.Constants;

namespace myNamespace.Methods
{
    public class __Sirius_MainVTButtons
    {
        public __Sirius_MainVTButtons(Panel Panel)
        {
            this.Panel = Panel;
        }
/*
        private bool BaseSanityCheck
        {
            get
            {
                if (Bluray != ControlSystem.GetSystem._blurayPlayer)
                {
                    Bluray = ControlSystem.GetSystem._blurayPlayer;
                }
                return Bluray != null;
            }
        }
*/
		
        public void Multi_Mode_Button(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_1(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_2(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_3(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_4(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_5(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_6(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_7(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Multi_Mode_Button_8(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        
        

        
        
        public IBasicBlurayPlayer Bluray;
        private Panel Panel;
    }
}