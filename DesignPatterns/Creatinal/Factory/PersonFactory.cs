using System;

namespace DesignPatterns.Creatinal.Factory
{
    public abstract class PersonFactory
    {
        public static Person CreatePerson(string fullName, int? cnh = null, int? license = null)
        {
            if (license != null)
            {
                return new Pilot
                {
                    FullName = fullName,
                    License = license.Value
                };
            }
            else if (cnh != null)
            {
                return new Driver
                {
                    CNH = cnh.Value,
                    FullName = fullName
                };
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
