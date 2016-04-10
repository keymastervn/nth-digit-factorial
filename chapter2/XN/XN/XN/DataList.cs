using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XN
{
    class DataList
    {
        public float _x { get; set; }
        public int _n { get; set; }
        public float _summation { get; set; }

        public float _multiplication { get; set; }

        public float _equal { get; set; }
        
        public DataList()
        {
            this.SetX(0);

        }
        public float GetX()
        {
            return this._x;
        }

        public void SetX(float x)
        {
            this._x = x;
        }

        public int GetN()
        {
            return this._n;
        }

        public void SetN(int n)
        {
            this._n = n;
        }

        public float GetSummation()
        {
            return this._summation;
        }

        public void SetSummation(float sum)
        {
            this._summation = sum;
        }

        public float GetMultiplication()
        {
            return this._multiplication;
        }

        public void SetMultiplication(float multi)
        {
            this._multiplication = multi;
        }

        public float GetEqual()
        {
            return this._equal;
        }

        public void SetEqual( float equal)
        {
            this._equal = equal;
        }


    }
}
