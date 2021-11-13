using System;

namespace BuilderInheritance
{
    public class PersonBirthDateBuilder<SELF>
        : PersonJobBuilder<PersonBirthDateBuilder<SELF>>
        where SELF : PersonBirthDateBuilder<SELF>
    {
        public SELF Born(DateTime dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (SELF)this;
        }
    }
}