using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGet
{
    public class ConsoleGets
    {
        private string message;
        private string input;
        public bool isValid;

        public ConsoleGets()
        {
            this.message = "Undefined";
        }
        public ConsoleGets(string msg)
        {
            this.message = msg;
        }
        private void Invalidate()
        {
            this.isValid = false;
        }
        private void Validate()
        {
            this.isValid = true;
        }
        public void setMessage(string msg)
        {
            if (this != null)
            {
                this.message = msg;
                this.Invalidate();
            }
        }
        private void SetInput(string inp)
        {
            this.input = inp;
        }
        private string GetInput()
        {
            return this.input;
        }
        public string Integer()
        {
            string retString = "null object";
            if (this != null)
            {
                int garbage;
                Console.Write(this.message);
                this.SetInput(Console.ReadLine());
                this.isValid = int.TryParse(this.GetInput(),out garbage);
                retString = this.GetInput();
            }
            return retString;
        }
        public string Integer(int min, int max)
        {
            string retString = "null object";
            if (this != null)
            {
                retString = this.Integer();                
                if (this.isValid)
                {
                    this.Invalidate();
                    int buffer = int.Parse(this.GetInput());
                    if (buffer>=min && buffer<=max)
                    {
                        this.Validate();
                    }
                }
            }
            return retString;
        }
    }
}
