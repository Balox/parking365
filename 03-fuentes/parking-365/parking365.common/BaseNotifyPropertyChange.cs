using System.ComponentModel;

namespace parking365.common {
  public class BaseNotifyPropertyChange : INotifyPropertyChanged {
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name) {
      PropertyChangedEventHandler handler = PropertyChanged;
      if(handler != null) {
        handler(this,new PropertyChangedEventArgs(name));
      }
    }
  }
}
