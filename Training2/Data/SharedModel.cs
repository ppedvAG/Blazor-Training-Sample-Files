using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Training2.Data
{
    public class SharedModel
    {
       

        private int _Zahl;

        public int Zahl
        {
            get { return _Zahl; }
            set { _Zahl = value;
                PropertyChanged();
            }
        }
        //analog zu MVVM aus WPF und UPW gedacht
        public event EventHandler PropertyChangedEvent;
        public async void PropertyChanged([CallerMemberName] string feldname=null)
        {
            PropertyChangedEvent?.Invoke(this, EventArgs.Empty);


        }

    }

}
