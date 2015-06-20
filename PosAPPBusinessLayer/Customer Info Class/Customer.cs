using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosAPPBusinessLayer.Error_Logging;

namespace PosAPPBusinessLayer.Customer_Info_Class
{
    public class Customer
    {
        private int id;
        private string customerNumber;
        private string firstName;
        private string otherName;
        private string fullName;
        private Nullable<DateTime> dob;
        private string age;
        private bool archived;

        public Customer()
        {
            try
            {
                this.id = 0;
                this.customerNumber = string.Empty;
                this.firstName = string.Empty;
                this.otherName = string.Empty;
                this.fullName = string.Empty;
                this.dob = null;
                this.age = string.Empty;
                this.archived = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string OtherName
        {
            get { return otherName; }
            set { otherName = value; }
        }

        public Nullable<DateTime> DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public bool Archived
        {
            get { return archived; }
            set { archived = value; }
        }

        public string GetFullName
        {
            get
            {
                try
                {
                    fullName = firstName + (otherName == string.Empty ? " " : " " + otherName + " ");
                    return fullName;
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex);
                    throw ex;
                }
            }
            set { fullName = value; }
        }

        public string Age
        {
            get
            {
                string age = String.Empty;
                try
                {
                    int yrcheck = DateTime.Now.Year - DateTime.Parse(dob.ToString()).Year;
                    int monthcheck = DateTime.Now.Month - DateTime.Parse(dob.ToString()).Month;
                    int daycheck = DateTime.Now.Day - DateTime.Parse(dob.ToString()).Day;
                    if (yrcheck == 0)
                    {
                        if (daycheck == 0 || daycheck > 0)
                            age = monthcheck + " months";
                        else
                            age = monthcheck - 1 + " months";
                    }
                    else if (yrcheck == 1)
                    {
                        if (monthcheck < 0)
                        {
                            if (daycheck > 0 || daycheck == 0)
                                age = monthcheck + 12 + " months";
                            else if (daycheck < 1)
                                age = (monthcheck - 1) + 12 + " months";
                        }
                        else if (monthcheck == 0)
                        {
                            if (daycheck == 0 || daycheck > 0)
                                age = "1 yr";
                            else if (daycheck < 0)
                                age = "11 months";
                            else if (monthcheck > 0)
                                age = "1 yr";
                        }
                    }
                    else if (yrcheck > 1)
                    {
                        if (monthcheck > 0)
                            age = yrcheck + " yrs";
                        else if (monthcheck < 0)
                            age = yrcheck - 1 + " yrs";
                        else if (monthcheck == 0)
                        {
                            if (daycheck == 0 && daycheck > 0)
                                age = yrcheck + " yrs";
                            else
                                age = yrcheck - 1 + " yrs";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex);
                    age = "N/A";
                }
                return age;
            }
            set { age = this.Age; }
        }   
    }
}
