//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Types: System.ComponentModel.INotifyPropertyChanged
    
    {
    #region Implement INotifyPropertyChanged
     
     public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
     
     protected virtual void OnPropertyChanged(string propertyName)
     {
      if (PropertyChanged != null)
      {
       PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
     }
     
     #endregion
        public Types()
        {
            this.Merchandise = new HashSet<Merchandise>();
        }
    
        private decimal _id_type;
     public decimal id_type 
     { 
      get
      {
       return _id_type;
      } 
      set
      {
       if(_id_type != value)
       {
        _id_type = value;
        OnPropertyChanged("id_type");
       }
      }
     }
     
        private string _name;
     public string name 
     { 
      get
      {
       return _name;
      } 
      set
      {
       if(_name != value)
       {
        _name = value;
        OnPropertyChanged("name");
       }
      }
     }
     
    
        private ICollection<Merchandise> _Merchandise;
     public virtual ICollection<Merchandise> Merchandise 
     { 
      get
      {
       return _Merchandise;
      } 
      set
      {
       if(_Merchandise != value)
       {
        _Merchandise = value;
        OnPropertyChanged("Merchandise");
       }
      }
     }
     
    }
}