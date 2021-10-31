using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3FinalProject2.Models
{
    public delegate void Notify(double amount);

    public class Balance
    {
        private double _amount;

        public event Notify Withdrawn;
        public event Notify Put;

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance can't be bellow then zero");
                }

                if (value < _amount)
                {
                    Withdrawn?.Invoke(_amount - value);
                }
                else if (value > _amount)
                {
                    Put?.Invoke(value - _amount);
                }

                _amount = value;
            }
        }
    }
}
