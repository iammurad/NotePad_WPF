﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged<T>(ref T property , T value, [CallerMemberName] string propertyName = "")
        {
            property = value;
            var handler = PropertyChanged;

            if(handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
