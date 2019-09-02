using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Employee
    {
        private float hourlyRate;
        private string name;
        private int tenure;
        private float workedHours;
        private float grossIncome;
        private float netIncome;
        private static float tenureBonus = 150;
        private static float incomeTax = 13;

        public Employee()
        {
            //this.hourlyRate = -1;
            //this.name = "Undefined";
            //this.tenure = -1;
            //this.workedHours = -1;
            this.netIncome = -1;
            //Employee.tenureBonus = (float) 150;
        }
        public Employee(float rate, string nm, int tnre, float hours) : this()
        {
            this.hourlyRate = rate;
            this.name = nm;
            this.tenure = tnre;
            this.workedHours = hours;
        }
        public void SetRate(float rate)
        {
            this.hourlyRate = rate;
        }
        public void SetName (string nm)
        {
            this.name = nm;
        }
        public void SetTenure(int tnre)
        {
            this.tenure = tnre;
        }
        public void SetWorkedHours(float hours)
        {
            this.workedHours = hours;
        }
        public void SetGrossIncome(float income)
        {
            if (this != null)
            {
                this.grossIncome = income;
            }
        }
        public float GetHourlyRate()
        {
            return this.hourlyRate;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetTenure()
        {
            return this.tenure;
        }
        public float GetWorkedHours()
        {
            return this.workedHours;
        }
        public float GetGrossIncome()
        {
            float retVal = -1;
            if (this != null)
            {
                retVal = this.grossIncome;
            }
            return retVal;
        }
        public float GetNetIncome()
        {
            float retVal = -1;
            if (this != null)
            {
                retVal = this.netIncome;
            }
            return retVal;
        }
        public void CalculateGrossIncome()
        {
            if (this != null)
            {
                float incomeBuffer;
                incomeBuffer = this.hourlyRate * this.workedHours;
                incomeBuffer += this.AddTenureBonus();
                this.SetGrossIncome(incomeBuffer);
            }
        }
        public void CalculateNetIncome ()
        {
            if (this != null)
            {
                this.CalculateGrossIncome();
                this.netIncome = this.GetGrossIncome() - this.Taxate();
            }
        }
        private float Taxate()
        {
            float retVal = -1;
            if (this != null)
            {
                retVal = (this.grossIncome / 100) * Employee.incomeTax;
            }
            return retVal;
        }
        private float AddTenureBonus()
        {
            float retVal = -1;
            if (this != null)
            {
                retVal = this.tenure * Employee.tenureBonus;
            }
            return retVal;
        }
        public string Show()
        {
            string retString = "null";
            if (this != null)
            {
                retString = (this.GetName() + " - " + this.GetTenure().ToString() + " - " + this.GetHourlyRate().ToString()
                    + " - " + this.GetGrossIncome().ToString() + " - " + this.GetNetIncome().ToString());
            }
            return retString;
        }
    }
}
