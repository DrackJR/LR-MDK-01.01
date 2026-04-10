using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR_PostgreSQL
{
    public class Event
    {
        private string venue_;
        private DateTime date_;
        private string executor_;
        private int cost_;
        [DisplayName("Место проведения")]
        public string Venue { get { return venue_; } set { venue_ = value; OnPropertyChanged(nameof(Venue)); } }
        [DisplayName("Дата")]
        public DateTime Date { get { return date_; } set { date_ = value; OnPropertyChanged(nameof(Date)); } }
        [DisplayName("Исполнитель")]
        public string Executor { get { return executor_; } set { executor_ = value; OnPropertyChanged(nameof(Executor)); } }
        [DisplayName("Цена")]
        public int Cost { get { return cost_; } set { cost_ = value; OnPropertyChanged(nameof(Cost)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
