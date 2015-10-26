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
    
    public partial class Merchandise: System.ComponentModel.INotifyPropertyChanged
    
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
        public Merchandise()
        {
            this.Send = new HashSet<Send>();
        }
    
        private decimal _id_merch;
     public decimal id_merch 
     { 
      get
      {
       return _id_merch;
      } 
      set
      {
       if(_id_merch != value)
       {
        _id_merch = value;
        OnPropertyChanged("id_merch");
       }
      }
     }
     
        private string _brand;
     public string brand 
     { 
      get
      {
       return _brand;
      } 
      set
      {
       if(_brand != value)
       {
        _brand = value;
        OnPropertyChanged("brand");
       }
      }
     }
     
        private string _specif_n;
     public string specif_n 
     { 
      get
      {
       return _specif_n;
      } 
      set
      {
       if(_specif_n != value)
       {
        _specif_n = value;
        OnPropertyChanged("specif_n");
       }
      }
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
     
        private decimal _count_order;
     public decimal count_order 
     { 
      get
      {
       return _count_order;
      } 
      set
      {
       if(_count_order != value)
       {
        _count_order = value;
        OnPropertyChanged("count_order");
       }
      }
     }
     
        private decimal _count_stored;
     public decimal count_stored 
     { 
      get
      {
       return _count_stored;
      } 
      set
      {
       if(_count_stored != value)
       {
        _count_stored = value;
        OnPropertyChanged("count_stored");
       }
      }
     }
     
        private decimal _count_send;
     public decimal count_send 
     { 
      get
      {
       return _count_send;
      } 
      set
      {
       if(_count_send != value)
       {
        _count_send = value;
        OnPropertyChanged("count_send");
       }
      }
     }
     
        private decimal _count_booked;
     public decimal count_booked 
     { 
      get
      {
       return _count_booked;
      } 
      set
      {
       if(_count_booked != value)
       {
        _count_booked = value;
        OnPropertyChanged("count_booked");
       }
      }
     }
     
        private decimal _consignment;
     public decimal consignment 
     { 
      get
      {
       return _consignment;
      } 
      set
      {
       if(_consignment != value)
       {
        _consignment = value;
        OnPropertyChanged("consignment");
       }
      }
     }
     
        private decimal _margin;
     public decimal margin 
     { 
      get
      {
       return _margin;
      } 
      set
      {
       if(_margin != value)
       {
        _margin = value;
        OnPropertyChanged("margin");
       }
      }
     }
     
        private decimal _cost;
     public decimal cost 
     { 
      get
      {
       return _cost;
      } 
      set
      {
       if(_cost != value)
       {
        _cost = value;
        OnPropertyChanged("cost");
       }
      }
     }
     
        private bool _arrived;
     public bool arrived 
     { 
      get
      {
       return _arrived;
      } 
      set
      {
       if(_arrived != value)
       {
        _arrived = value;
        OnPropertyChanged("arrived");
       }
      }
     }
     
    
        private Order _Order;
     public virtual Order Order 
     { 
      get
      {
       return _Order;
      } 
      set
      {
       if(_Order != value)
       {
        _Order = value;
        OnPropertyChanged("Order");
       }
      }
     }
     
        private Types _Types;
     public virtual Types Types 
     { 
      get
      {
       return _Types;
      } 
      set
      {
       if(_Types != value)
       {
        _Types = value;
        OnPropertyChanged("Types");
       }
      }
     }
     
        private ICollection<Send> _Send;
     public virtual ICollection<Send> Send 
     { 
      get
      {
       return _Send;
      } 
      set
      {
       if(_Send != value)
       {
        _Send = value;
        OnPropertyChanged("Send");
       }
      }
     }
     
    }
}