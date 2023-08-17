using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    //<ClassModifier> -> public, internal (default)
    //<ClassModifier> class <ClassName>
    //{
    // class block
    //}
    public class empolyee
    {

        //Constant -> <AccessModifier> const <DataType> <ConstantName> = <Value>;
        public const double TAX = 0.03;
        //<AccessModifiers> public , private , protected
        //fields -> <AccessModifier> <DataType> <FieldName> = <InitialValue>;
        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;
    }
}
