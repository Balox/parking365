﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingDemo.data {
  public class BaseNotifyPropertyChange : INotifyPropertyChanged {
    public event PropertyChangedEventHandler PropertyChanged;

    // Create the OnPropertyChanged method to raise the event
    protected void OnPropertyChanged(string name) {
      PropertyChangedEventHandler handler = PropertyChanged;
      if(handler != null) {
        handler(this,new PropertyChangedEventArgs(name));
      }
    }
  }
}
